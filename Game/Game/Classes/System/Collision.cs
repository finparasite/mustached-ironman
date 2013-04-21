using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game
{
    static class Collision
    {
        public static int CheckIfCollidesLevel(Rectangle input)
        {
            foreach (Rectangle rect in Level.LevelCollision)
            {
                if (CheckIfCollides(input, rect))
                    return rect.Top;
            }

            return 0;
        }

        public static bool CheckIfCollides(Rectangle a, Rectangle b)
        {
            if (a.Right >= b.Left &&
                a.Bottom >= b.Top &&
                a.Left <= b.Right &&
                a.Top <= b.Bottom)
                return true;

            return false;
        }
    }
}
