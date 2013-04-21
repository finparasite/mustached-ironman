using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    static class Camera2D
    {
        private static Vector2 pos = new Vector2(0.0f, 0.0f);
        private static Matrix transform;

        public static Matrix Transform
        {
            get { return transform; }
        }

        public static void MoveRelative(Vector2 moveVect)
        {
            pos += moveVect;
        }

        public static void MoveAbsolute(Vector2 newPos)
        {
            pos = newPos;
        }

        public static void Update(Viewport vp)
        {
            UpdatePosition();
            UpdateMatrix(vp);
        }

        private static void UpdatePosition()
        {
            if (Player.PlayerRef != null)
                pos = Player.PlayerRef.Position;
        }

        private static void UpdateMatrix(Viewport vp)
        {
            transform = Matrix.CreateTranslation(new Vector3(-pos.X, -pos.Y, 0.0f)) *
                        Matrix.CreateRotationZ(0.0f) *
                        Matrix.CreateScale(new Vector3(1.0f, 1.0f, 1.0f)) *
                        Matrix.CreateTranslation(new Vector3(vp.Width * 0.5f, vp.Height * 0.5f, 0.0f));
        }
    }
}
