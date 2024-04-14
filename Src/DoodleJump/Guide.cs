// Type: mrGame.Guide
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace mrGame
{
    internal class Guide
    {
        internal static bool IsTrialMode;
        internal static bool IsVisible;

        internal static IAsyncResult BeginShowKeyboardInput(PlayerIndex one, string v1, string v2, string v3, AsyncCallback asyncCallback, object v4)
        {
            return default;
        }

        internal static void BeginShowMessageBox(string v1, string v2, IEnumerable<string> enumerable, int v3, object alert, AsyncCallback asyncCallback, object v4)
        {
            //
        }

        internal static string EndShowKeyboardInput(IAsyncResult result)
        {
            return default;
        }

        internal static int? EndShowMessageBox(IAsyncResult userResult)
        {
            return default; 
        }

        internal static void ShowMarketplace(PlayerIndex one)
        {
            //
        }
    }
}