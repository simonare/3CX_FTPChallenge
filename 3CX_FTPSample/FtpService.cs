using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentFTP;

namespace _3CX_FTPSample
{
    public interface IFtpService : IDisposable
    {
        Task Connect(string host, int port, string username, string password, CancellationToken cancellationToken = default);
        Task SetWorkingDirectory(string path, CancellationToken cancellationToken = default);
        Task<FtpListItem[]> GetListing(CancellationToken cancellationToken = default);
        Task Disconnect(CancellationToken cancellationToken = default);
        Task DownloadFile(string fileName, Action<FtpProgress> progressHandler, CancellationToken cancellationToken = default);
    }
    
    public class FtpService : IFtpService, IDisposable
    {
        private Task _connectTask;

        private readonly IFtpClient _ftpClient;
        public FtpService()
        {
            _ftpClient = new FtpClient()
            {
                EnableThreadSafeDataConnections = true
            };
        }

        public async Task Connect(string host, int port, string username, string password, CancellationToken cancellationToken = default)
        {
            if (_ftpClient.IsConnected)
            {
                throw new CustomApplicationException("The FtpClient is already connected");
            }

            _ftpClient.Host = host;
            _ftpClient.Port = port;
            _ftpClient.Credentials = new NetworkCredential(username, password);
            _connectTask = _ftpClient.ConnectAsync(cancellationToken);
            await _connectTask;
        }

        public Task SetWorkingDirectory(string path, CancellationToken cancellationToken = default)
        {
            return _ftpClient.SetWorkingDirectoryAsync(path, cancellationToken);
        }

        public async Task<FtpListItem[]> GetListing(CancellationToken cancellationToken = default)
        {
            return await _ftpClient.GetListingAsync(await _ftpClient.GetWorkingDirectoryAsync(cancellationToken), cancellationToken);
        }

        public async Task Disconnect(CancellationToken cancellationToken = default)
        {
            if (!_ftpClient.IsConnected)
            {
                throw new CustomApplicationException("Not Connected");
            }

            await _ftpClient.DisconnectAsync(cancellationToken);
        }

        public Task DownloadFile(string fileName, Action<FtpProgress> progressHandler, CancellationToken cancellationToken = default)
        {
            return _ftpClient.DownloadFileAsync(fileName, fileName, FtpLocalExists.Overwrite, FtpVerify.None,
                new Progress<FtpProgress>(progressHandler), cancellationToken);
        }

        public async void Dispose()
        {
            _connectTask?.Dispose();

            if (_ftpClient.IsConnected)
                await _ftpClient.DisconnectAsync();

            if (!_ftpClient.IsDisposed)
                _ftpClient.Dispose();
        }
    }
}
