using System;
using System.IO;
using Renci.SshNet;

namespace Shellow.Models
{
    class ProtocolBase : IProtocol
    {
        protected Configuration.Configuration _config = new Configuration.Configuration();

        protected PrivateKeyAuthenticationMethod _privateKeyAuthMethod;

        protected BaseClient _client;

        protected ProtocolBase()
        {
            string sshKeyPath;
            if (this._config.PrivateKeyPath.Trim().Length == 0)
            {
                sshKeyPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".ssh", this._config.PrivateKeyName);
            }
            else
            {
                sshKeyPath = Path.Combine(this._config.PrivateKeyPath, this._config.PrivateKeyName);
            }
            this._privateKeyAuthMethod = new PrivateKeyAuthenticationMethod(this._config.UserName, new PrivateKeyFile(sshKeyPath, this._config.FingerPrint));
        }

        public void Connect()
        {
            if (!this._client.IsConnected)
            {
                this._client.Connect();
            }
        }

        public void Disconnect()
        {
            if (this._client.IsConnected)
            {
                this._client.Disconnect();
            }
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._client.Disconnect();
                    this._client.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
