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
        // Last keyboard state
        private static KeyboardState lks;

        static InputManager()
        {
            lks = Keyboard.GetState();
        }

        public static void Update()
        {
            KeyboardState ks = Keyboard.GetState();
            Vector2 moveVector = Vector2.Zero;
            bool firing = false;
            bool jumping = false;

            if (ks.IsKeyDown(Keys.D))
                moveVector += Vector2.UnitX;
            if (ks.IsKeyDown(Keys.A))
                moveVector += -Vector2.UnitX;

            // If space not down in last update
            if (!lks.IsKeyDown(Keys.Space))
                jumping = ks.IsKeyDown(Keys.Space);

            MouseState ms = Mouse.GetState();
            firing = (ms.LeftButton == ButtonState.Pressed);

            // Return if Player not yet created
            if (Player.PlayerRef == null)
                return;

            if (jumping)
                Player.PlayerRef.Jump();

            Player.PlayerRef.AddVelocity(moveVector);
            if (firing)
                Player.PlayerRef.Fire(new Vector2(ms.X, ms.Y));

            lks = ks;
        }
    }
}
