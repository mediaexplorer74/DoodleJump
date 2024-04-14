// Type: mrGame.mrGame
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;

namespace mrGame
{
    public class SignedInGamer
    {
        public static EventHandler<SignedInEventArgs> SignedIn;
        public static string Gamertag;

        public List<Int32> Columns;

        public AchievementCollection EndGetAchievements(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        internal void BeginAwardAchievement(string v, AsyncCallback asyncCallback, object p_SignedInGamer)
        {
            throw new NotImplementedException();
        }

        internal void BeginGetAchievements(AsyncCallback asyncCallback, object p_SignedInGamer)
        {
            throw new NotImplementedException();
        }

        internal void EndAwardAchievement(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public static class LeaderboardWriter
        {
            public static LeaderboardEntry GetLeaderboard(LeaderboardIdentity leaderboardId1)
            {
                throw new NotImplementedException();
            }
        }
    }
}