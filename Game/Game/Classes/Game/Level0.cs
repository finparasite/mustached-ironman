using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    class Level0 : Level
    {
        public static Texture2D niki;

        public override void LoadContent(ContentManager Content)
        {
            // TODO
            niki = Content.Load<Texture2D>(@"Bitmaps/niki");
        }

        public override void SetupLevel()
        {
            // TODO
            player = new Player(Vector2.Zero, niki);
        }
    }
}
