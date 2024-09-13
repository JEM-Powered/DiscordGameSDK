// Discord Game SDK v3.2.1
// https://discord.com/developers/docs/developer-tools/game-sdk

#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX) && !UNITY_SERVER
#define UNITY_PC
#endif

#if UNITY_PC
using System;
using System.Collections.Generic;
using System.Text;

namespace Discord
{
    public partial class StorageManager
    {
        public IEnumerable<FileStat> Files()
        {
            var fileCount = Count();
            var files = new List<FileStat>();
            for (var i = 0; i < fileCount; i++)
            {
                files.Add(StatAt(i));
            }
            return files;
        }
    }
}
#endif