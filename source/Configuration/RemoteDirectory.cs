using System.Collections.Generic;

namespace Shellow.Configuration
{
    internal class RemotePaths
    {
        public string RemoteDirectory { get; set; } = Properties.Settings.Default.remoteDirectory;

        public string File { get; set; }

        public List<string> IgnoreFiles { get; set; } = new List<string>();

        public RemotePaths()
        {
            var list = Properties.Settings.Default.ignoreList;
            foreach (var i in list)
            {
                IgnoreFiles.Add(i);
            }
        }
    }
}
