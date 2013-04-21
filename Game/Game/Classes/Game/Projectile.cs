using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    class Projectile : DynamicActor
    {
        protected static Texture2D projectileTexture;

        static Projectile()
        {
            //projectileTexture = Game1.Content.Load<Texture2D>(@"Textures/Projectile");
        }

        public Projectile(Audio audio, Vector2 position, Vector2 velocity, float spread)
            : base("null", audio, position, 1.0f, 0.0f, Color.White, projectileTexture)
        {

        }
    }
}
