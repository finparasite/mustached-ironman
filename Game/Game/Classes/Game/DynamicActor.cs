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
            MoveRelative(velocity);

            if (!isGrounded)
                CheckCollision();

            if (listenToGravity && !isGrounded)
                ApplyGravity();
        }

        protected void CheckCollision()
        {
            int colliderTop = Collision.CheckIfCollidesLevel(new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height));

           if (colliderTop != 0)
            {
                isGrounded = true;
                velocity.Y = 0.0f;
                position.Y = colliderTop - texture.Height;
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
