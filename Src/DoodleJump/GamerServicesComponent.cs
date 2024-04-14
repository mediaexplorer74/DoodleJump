// Type: mrGame.GamerServicesComponent
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using Microsoft.Xna.Framework;

namespace mrGame
{
    internal class GamerServicesComponent
    {
        internal bool Enabled;
        private Game xnagame;

        public GamerServicesComponent(Game xnagame)
        {
            this.xnagame = xnagame;
        }
    }
}