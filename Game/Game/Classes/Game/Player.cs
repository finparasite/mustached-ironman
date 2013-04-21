using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    class Player : Pawn
    {
        protected static Player player;

        public static Player PlayerRef
        {
            get { return player; }
        }

        public Player(Vector2 position, Texture2D texture)
            : base("Player", null, position, 1.0f, 0, Color.White, texture)
        {
            player = this;
        }
    }
}
