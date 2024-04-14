// Type: mrGame.mrGame
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;

namespace mrGame
{
    public class LeaderboardReader
    {
        internal List<SignedInGamer> Entries;
        internal long PageStart;
        internal bool CanPageUp;
        internal bool CanPageDown;

        internal static void BeginRead(LeaderboardIdentity identity, Gamer p_SignedInGamer, int numScoresPerPage, AsyncCallback asyncCallback, object asyncState)
        {
            throw new NotImplementedException();
        }

        internal static void BeginRead(LeaderboardIdentity identity, int startingPage, int numScoresPerPage, AsyncCallback asyncCallback, object asyncState)
        {
            throw new NotImplementedException();
        }

        internal static LeaderboardReader EndRead(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal void BeginPageDown(AsyncCallback asyncCallback, object pXblaLeaderboard)
        {
            throw new NotImplementedException();
        }

        internal void BeginPageUp(AsyncCallback asyncCallback, object pXblaLeaderboard)
        {
            throw new NotImplementedException();
        }

        internal void EndPageDown(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal void EndPageUp(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }
}