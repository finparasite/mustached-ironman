using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    class DynamicActor : Actor
    {
        protected static List<DynamicActor> dynamicActors;

        protected Vector2 velocity;
        protected bool isGrounded = false;
        protected bool listenToGravity = true;

        public static List<DynamicActor> DynamicActors
        {
            get { return dynamicActors; }
        }

        static DynamicActor()
        {
            dynamicActors = new List<DynamicActor>();
        }

        public DynamicActor(string name, Audio audio, Vector2 position, float scale, float rotation, Color color, Texture2D texture)
            : base(name, audio, position, scale, rotation, color, texture)
        {
            dynamicActors.Add(this);
        }

        public virtual void Update()
        {
            if (!isGrounded)
                CheckCollision();

            if (listenToGravity && !isGrounded)
                ApplyGravity();

            MoveRelative(velocity);
        }

        protected void CheckCollision()
        {
            if (Collision.CheckIfCollidesLevel(new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height)))
            {
                isGrounded = true;
                velocity.Y = 0.0f;
            }
        }

        protected void ApplyGravity()
        {
            velocity.Y += 0.978f;
        }

        protected void MoveRelative(Vector2 vect2)
        {
            position += vect2;
        }
    }
}
