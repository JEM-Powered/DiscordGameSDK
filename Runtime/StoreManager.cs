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
    public partial class StoreManager
    {
        public IEnumerable<Entitlement> GetEntitlements()
        {
            var count = CountEntitlements();
            var entitlements = new List<Entitlement>();
            for (var i = 0; i < count; i++)
            {
                entitlements.Add(GetEntitlementAt(i));
            }
            return entitlements;
        }

        public IEnumerable<Sku> GetSkus()
        {
            var count = CountSkus();
            var skus = new List<Sku>();
            for (var i = 0; i < count; i++)
            {
                skus.Add(GetSkuAt(i));
            }
            return skus;
        }
    }
}
#endif