using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game
{
    abstract class Level : GameItem
    {
        protected Texture2D background;

        public abstract void LoadContent(ContentManager Content);

        public abstract void SetupLevel();

        public void DrawBackground(SpriteBatch sb, Viewport vp)
        {
            if (background != null)
                sb.Draw(background, new Rectangle(0, 0, vp.Width, vp.Height), Color.White);
        }
    }
}
