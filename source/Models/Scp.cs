using Renci.SshNet;

namespace Shellow.Models
{
    internal class Scp : ProtocolBase
    {
        public Scp()
        {
            this._client = new ScpClient(new ConnectionInfo(this._config.Destination, this._config.Port, this._config.UserName, this._privateKeyAuthMethod));
        }
    }
}
