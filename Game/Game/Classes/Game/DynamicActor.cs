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

        protected void MoveRelative(Vector2 vect2)
        {
            position += vect2;
        }

        public void Update()
        {
            MoveRelative(velocity);
        }
    }
}
