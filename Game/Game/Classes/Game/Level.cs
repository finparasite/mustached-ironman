using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;

namespace Game
{
    class Level : GameItem
    {
        protected static Player player;

        public static Player Player
        {
            get { return player; }
        }

        public virtual void LoadContent(ContentManager Content)
        {
        }

        public virtual void SetupLevel()
        {
        }

    }
}
