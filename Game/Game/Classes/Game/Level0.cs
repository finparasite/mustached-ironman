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
        public sealed override void LoadContent(ContentManager Content)
        {
            background = Content.Load<Texture2D>(@"Bitmaps/Level0/BG");
            playerTexture = Content.Load <Texture2D>(@"Bitmaps/Player");
        }

        public sealed override void SetupLevel()
        {
            SetupLevelCollision();
            new Player(new Vector2(0, 0), playerTexture);
        }

        protected sealed override void SetupLevelCollision()
        {
            levelCollision.Add(new Rectangle(-1000, 300, 2000, 100));
        }
    }
}
