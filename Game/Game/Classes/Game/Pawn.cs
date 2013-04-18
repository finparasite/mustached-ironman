using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game
{
    class Pawn : DynamicActor
    {
        float maxspeed = 3.0f;
        float speed = 0.1f;

        public void AddVelocity(Vector2 dir)
        {
            dir += velocity;
            if (velocity.X > maxspeed)
                velocity.X = maxspeed;

            else if (velocity.X < -maxspeed)
                velocity.X = -maxspeed;
                
        }
    }
}
