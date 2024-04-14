// Type: mrGame.mrGame
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;

namespace mrGame
{
    public class LeaderboardReader
    {
        public List<SignedInGamer> Entries;
        public long PageStart;
        public bool CanPageUp;
        public bool CanPageDown;

        public static void BeginRead(LeaderboardIdentity identity, 
            Gamer p_SignedInGamer, int numScoresPerPage, AsyncCallback asyncCallback, object asyncState)
        {
            //
        }

        public static void BeginRead(LeaderboardIdentity identity, int startingPage, 
            int numScoresPerPage, AsyncCallback asyncCallback, object asyncState)
        {
            //
        }

        public static LeaderboardReader EndRead(IAsyncResult result)
        {
            return default;
        }

        public void BeginPageDown(AsyncCallback asyncCallback, object pXblaLeaderboard)
        {
            //
        }

        public void BeginPageUp(AsyncCallback asyncCallback, object pXblaLeaderboard)
        {
            //
        }

        public void EndPageDown(IAsyncResult result)
        {
            //
        }

        public void EndPageUp(IAsyncResult result)
        {
            //
        }
    }
}