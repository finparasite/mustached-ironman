using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Game
{
    static class Utils
    {
        public static Vector2 ScreenPointToVector(Vector2 pos)
        {
            pos.X -= Game1.ViewportRef.Width / 2;
            pos.Y -= Game1.ViewportRef.Height / 2;

            return pos;
        }

        public static float AngleFromVector2(Vector2 vect2)
        {
            return (float)Math.Atan2(vect2.Y, vect2.X);
        }
    }
}
