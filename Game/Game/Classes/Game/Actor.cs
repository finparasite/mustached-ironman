using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    class Actor : GameItem
    {
        protected static List<Actor> actors;

        protected Vector2 position = new Vector2(0, 0);
        protected float scale = 1.0f;
        protected float rotation;

        protected Color color = Color.White;

        protected Texture2D texture;

        public static List<Actor> Actors
        {
            get { return actors; }
        }

        public Vector2 Position
        {
            get { return position; }
        }

        protected Vector2 origin
        {
            get
            {
                float x = texture.Width / 2;
                float y = texture.Height / 2;

                return new Vector2(x, y);
            }
        }

        static Actor()
        {
            actors = new List<Actor>();
        }

        public Actor(string name, Audio audio)
            : base(name, audio)
        {
            actors.Add(this);
        }

        public Actor(string name, Audio audio, Vector2 position, float scale, float rotation, Color color, Texture2D texture)
            : this(name, audio)
        {
            this.position = position;
            this.scale = scale;
            this.rotation = rotation;
            this.color = color;
            this.texture = texture;
        }

        public virtual void Draw(SpriteBatch sb)
        {
            if (texture == null)
                return;

            sb.Draw(texture, position, new Rectangle(0, 0, texture.Width, texture.Height), color, rotation, origin, scale, SpriteEffects.None, 0.5f);
        }
    }
}
