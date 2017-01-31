using Renci.SshNet;

namespace Shellow.Models
{
    internal class Ssh : ProtocolBase
    {
        public Ssh()
        {
            this._client = new SshClient(new ConnectionInfo(this._config.Destination, this._config.Port, this._config.UserName, this._privateKeyAuthMethod));
        }
    }
}
