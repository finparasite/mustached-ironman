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
        public static Texture2D projectileTexture;

        public Projectile(Audio audio, Vector2 position, Vector2 velocity, float angle, float spread)
            : base("null", audio, position, 1.0f, angle, Color.White, projectileTexture)
        {
            this.velocity = velocity;
            listenToGravity = false;
        }
    }
}
