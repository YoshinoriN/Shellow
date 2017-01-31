namespace Shellow.Configuration
{
    internal class Configuration
    {
        public string Destination { get; } = Properties.Settings.Default.destination;

        public int Port { get; } = Properties.Settings.Default.port;

        public string UserName { get; } = Properties.Settings.Default.userName;

        public string PrivateKeyPath { get; } = Properties.Settings.Default.privateKeyDirectory;

        public string PrivateKeyName { get; } = Properties.Settings.Default.privateKeyName;

        public string FingerPrint { get; } = Properties.Settings.Default.fingerPrint;
    }
}
