using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    class Pawn : DynamicActor
    {
        float maxspeed = 3.0f;
        float speed = 0.1f;

        public Pawn(string name, Audio audio, Vector2 position, float scale, float rotation, Color color, Texture2D texture)
            : base(name, audio, position, scale, rotation, color, texture)
        {}

        public void AddVelocity(Vector2 dir)
        {
            dir += velocity;
            if (velocity.X > maxspeed)
                velocity.X = maxspeed;

            else if (velocity.X < -maxspeed)
                velocity.X = -maxspeed;
                
        }

        public void Fire(Vector2 mousepos)
        {
        }
    }
}
