// Type: mrGame.mrGame
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
            throw new NotImplementedException();
        }

        internal static void BeginShowMessageBox(string v1, string v2, IEnumerable<string> enumerable, int v3, object alert, AsyncCallback asyncCallback, object v4)
        {
            throw new NotImplementedException();
        }

        internal static string EndShowKeyboardInput(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal static int? EndShowMessageBox(IAsyncResult userResult)
        {
            throw new NotImplementedException();
        }

        internal static void ShowMarketplace(PlayerIndex one)
        {
            throw new NotImplementedException();
        }
    }
}