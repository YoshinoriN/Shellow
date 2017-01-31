namespace Shellow.Models
{
    class ProtocolFactory
    {
        public IProtocol CrateProtocol(int protpcolType)
        {
            switch ((Models.ProtocolTypeEnum)protpcolType)
            {
                case (ProtocolTypeEnum.Ssh):
                    return new Ssh();
                case (ProtocolTypeEnum.Scp):
                    return new Ssh();
                case (ProtocolTypeEnum.Sftp):
                    return new Ssh();
            }
            //TODO : Need fix.
            throw new System.Exception();
        }
    }
}
