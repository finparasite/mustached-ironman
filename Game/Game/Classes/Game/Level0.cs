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
        }

        public sealed override void SetupLevel()
        {
            // TODO
        }
    }
}
