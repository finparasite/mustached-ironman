using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Game
{
    static class InputManager
    {
        public static void Update()
        {
            KeyboardState ks = Keyboard.GetState();
            Vector2 moveVector = Vector2.Zero;

            if (ks.IsKeyDown(Keys.W))
                moveVector += -Vector2.UnitY;
            if (ks.IsKeyDown(Keys.D))
                moveVector += -Vector2.UnitX;
            if (ks.IsKeyDown(Keys.S))
                moveVector += Vector2.UnitY;
            if (ks.IsKeyDown(Keys.A))
                moveVector += -Vector2.UnitX;

            Level.Player.AddVelocity(moveVector.Normalize());

            MouseState ms = Mouse.GetState();
            if (ms.LeftButton == ButtonState.Pressed)
                Level.Player.Fire(new Vector2(ms.X, ms.Y));
        }
    }
}
