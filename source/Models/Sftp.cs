using System;
using System.Linq;
using Renci.SshNet;
namespace Shellow.Models
{
    internal class Sftp : ProtocolBase
    {
        public Sftp()
        {
            this._client = new SftpClient(new ConnectionInfo(this._config.Destination, this._config.Port, this._config.UserName, this._privateKeyAuthMethod));
        }
    }
}
