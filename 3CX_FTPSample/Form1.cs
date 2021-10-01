using System;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;

namespace _3CX_FTPSample
{
    public partial class Form1 : Form
    {
        private readonly IFtpService _ftpService ;
        private Task _connectTask;
        private Task _downloadTask;
        private CancellationTokenSource _cancellationTokenSource = new();
        private CancellationTokenSource _cancelDownloadTokenSource;
        private readonly ResourceManager _resources;
        public Form1()
        {
            _ftpService = new FtpService();
            _resources = new ResourceManager(this.GetType()); 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource ??= new CancellationTokenSource();
            var cToken = _cancellationTokenSource.Token;

            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            var host = hostTextbox.Text;
            var port = Convert.ToInt32(portNumericUpDown.Text);
            var username = usernameTextbox.Text;
            var password = passwordTextbox.Text;
            _connectTask = _ftpService.Connect(host, port, username, password, cToken);
            try
            {
                await _connectTask;
                await _ftpService.SetWorkingDirectory(workDirTextbox.Text, cToken);
                var listing = await _ftpService.GetListing(cToken);
                dataGridView1.DataSource = listing.Select(t => new {t.Name, Size = FormatByteTransferred(t.Size), t.Type}).ToList();
            }
            catch (CustomApplicationException)
            {
                throw;
            }
            catch (Exception)
            {
                dataGridView1.DataSource = null;
                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
            }
        }

        private async void DisconnectButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();

            await _ftpService.Disconnect();

            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            dataGridView1.DataSource = null;

            _cancellationTokenSource?.Dispose();
            _cancellationTokenSource = null;

            _cancelDownloadTokenSource?.Dispose();
            _cancelDownloadTokenSource = null;

        }

        private string FormatByteTransferred(long received)
        {
            if (received < 1 * 1024)
                return received + " B";
            else if (received < 1L * Math.Pow(1024, 2))
                return (received / 1024).ToString("D") + " Kb";
            else if (received < 1L * Math.Pow(1024, 3))
                return (received / Math.Pow(1024,2)).ToString("N") + " Mb";
            else if (received < 1L * Math.Pow(1024, 4))
                return (received / Math.Pow(1024, 3)).ToString("N") + " Gb";
            else 
                return (received / Math.Pow(1024, 4)).ToString("N") + " Tb";

        }

        private async void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex < 0)
                return;

            _cancelDownloadTokenSource ??= CancellationTokenSource.CreateLinkedTokenSource(_cancellationTokenSource.Token);

            if (_downloadTask?.Status == TaskStatus.WaitingForActivation)
            {
                var res = MessageBox.Show(_resources.GetString("Form1_single_file_download"), "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var cToken = _cancelDownloadTokenSource.Token;

            toolStripProgressBar1.Value = 0;
            Action<FtpProgress> progressHandler = p =>
            {  
                toolStripProgressBar1.Value = Convert.ToInt32(p.Progress);
                toolStripStatusLabel1.Text = $@"%{toolStripProgressBar1.Value} ETA: {p.ETA:hh\:mm\:ss} Rtx: {FormatByteTransferred(p.TransferredBytes)} Speed: {p.TransferSpeedToString()} ";
            };

            var fileName = dataGridView1[0, e.RowIndex].Value.ToString();

            try
            {
                toolstripCancelButton.Visible = true;
                _downloadTask = _ftpService.DownloadFile(fileName, progressHandler, cToken);
                await _downloadTask;
            }
            catch (OperationCanceledException)
            {
                toolStripProgressBar1.Value = 0;
                toolStripStatusLabel1.Text = "Operation cancelled";
                toolstripCancelButton.Visible = false;
                
            }
        }

        private void AnonymousCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (anonymousCheckBox.Checked)
            {
                usernameTextbox.Text = "anonymous";
                passwordTextbox.Text = "";
            }

            usernameTextbox.ReadOnly = anonymousCheckBox.Checked;
            passwordTextbox.ReadOnly = anonymousCheckBox.Checked;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cancelDownloadTokenSource?.Cancel();
            _cancelDownloadTokenSource?.Dispose();

            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource?.Dispose();

            _ftpService.Dispose();

            //_downloadTask?.Dispose();
            //connectTask?.Dispose();
        }


        private void ToolstripCancelButtonOnClick(object? sender, EventArgs e)
        {
            _cancelDownloadTokenSource?.Cancel();
            _cancelDownloadTokenSource?.Dispose();
            _cancelDownloadTokenSource = null;
        }
    }
}
