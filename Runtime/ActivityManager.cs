// Discord Game SDK v3.2.1
// https://discord.com/developers/docs/developer-tools/game-sdk

#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX) && !UNITY_SERVER
#define UNITY_PC
#endif

#if UNITY_PC
using System;

namespace Discord
{
    public partial class ActivityManager
    {
        public void RegisterCommand()
        {
            RegisterCommand(null);
        }
    }
}
#endif