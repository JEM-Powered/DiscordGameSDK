// Discord Game SDK v3.2.1
// https://discord.com/developers/docs/developer-tools/game-sdk

#if (UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX) && !UNITY_SERVER
#define UNITY_PC
#endif

#if UNITY_PC
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

namespace Discord
{
    public partial class LobbyManager
    {
        public IEnumerable<User> GetMemberUsers(Int64 lobbyID)
        {
            var memberCount = MemberCount(lobbyID);
            var members = new List<User>();
            for (var i = 0; i < memberCount; i++)
            {
                members.Add(GetMemberUser(lobbyID, GetMemberUserId(lobbyID, i)));
            }
            return members;
        }

        public void SendLobbyMessage(Int64 lobbyID, string data, SendLobbyMessageHandler handler)
        {
            SendLobbyMessage(lobbyID, Encoding.UTF8.GetBytes(data), handler);
        }
    }
}
#endif