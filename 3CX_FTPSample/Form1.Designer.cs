
using System.Drawing;

namespace _3CX_FTPSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hostTextbox = new System.Windows.Forms.TextBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.anonymousCheckBox = new System.Windows.Forms.CheckBox();
            this.workDirLabel = new System.Windows.Forms.Label();
            this.workDirTextbox = new System.Windows.Forms.TextBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolstripCancelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostTextbox
            // 
            this.hostTextbox.Location = new System.Drawing.Point(88, 15);
            this.hostTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hostTextbox.Name = "hostTextbox";
            this.hostTextbox.Size = new System.Drawing.Size(241, 23);
            this.hostTextbox.TabIndex = 0;
            this.hostTextbox.Text = "ftp.linux.org.tr";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(10, 17);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(38, 15);
            this.hostLabel.TabIndex = 1;
            this.hostLabel.Text = "Host :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.instructionsLabel);
            this.groupBox1.Controls.Add(this.anonymousCheckBox);
            this.groupBox1.Controls.Add(this.workDirLabel);
            this.groupBox1.Controls.Add(this.workDirTextbox);
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.usernameTextbox);
            this.groupBox1.Controls.Add(this.portNumericUpDown);
            this.groupBox1.Controls.Add(this.hostLabel);
            this.groupBox1.Controls.Add(this.hostTextbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(700, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // anonymousCheckBox
            // 
            this.anonymousCheckBox.AutoSize = true;
            this.anonymousCheckBox.Checked = true;
            this.anonymousCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.anonymousCheckBox.Location = new System.Drawing.Point(494, 42);
            this.anonymousCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anonymousCheckBox.Name = "anonymousCheckBox";
            this.anonymousCheckBox.Size = new System.Drawing.Size(124, 19);
            this.anonymousCheckBox.TabIndex = 11;
            this.anonymousCheckBox.Text = "Anonymous Login";
            this.anonymousCheckBox.UseVisualStyleBackColor = true;
            this.anonymousCheckBox.CheckedChanged += new System.EventHandler(this.AnonymousCheckBox_CheckedChanged);
            // 
            // workDirLabel
            // 
            this.workDirLabel.AutoSize = true;
            this.workDirLabel.Location = new System.Drawing.Point(435, 16);
            this.workDirLabel.Name = "workDirLabel";
            this.workDirLabel.Size = new System.Drawing.Size(59, 15);
            this.workDirLabel.TabIndex = 10;
            this.workDirLabel.Text = "Work Dir :";
            // 
            // workDirTextbox
            // 
            this.workDirTextbox.Location = new System.Drawing.Point(512, 14);
            this.workDirTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workDirTextbox.Name = "workDirTextbox";
            this.workDirTextbox.Size = new System.Drawing.Size(163, 23);
            this.workDirTextbox.TabIndex = 9;
            this.workDirTextbox.Text = "centos/8.4.2105/isos/x86_64/";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(98, 68);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(82, 22);
            this.disconnectButton.TabIndex = 8;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(10, 68);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(82, 22);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(261, 42);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 15);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password :";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(333, 40);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.ReadOnly = true;
            this.passwordTextbox.Size = new System.Drawing.Size(156, 23);
            this.passwordTextbox.TabIndex = 5;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(10, 42);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(66, 15);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username :";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(88, 40);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.ReadOnly = true;
            this.usernameTextbox.Size = new System.Drawing.Size(163, 23);
            this.usernameTextbox.TabIndex = 3;
            this.usernameTextbox.Text = "anonymous";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(333, 15);
            this.portNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(88, 23);
            this.portNumericUpDown.TabIndex = 2;
            this.portNumericUpDown.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(700, 222);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolstripCancelButton,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.AutoToolTip = true;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(350, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolstripCancelButton
            // 
            this.toolstripCancelButton.Name = "toolstripCancelButton";
            this.toolstripCancelButton.Size = new System.Drawing.Size(23, 20);
            this.toolstripCancelButton.Text = "X";
            this.toolstripCancelButton.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(200, 74);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(38, 15);
            this.instructionsLabel.TabIndex = 12;
            this.instructionsLabel.Text = "* Double click on filename to Download";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostTextbox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Button connectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label workDirLabel;
        private System.Windows.Forms.TextBox workDirTextbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox anonymousCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolstripCancelButton;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

