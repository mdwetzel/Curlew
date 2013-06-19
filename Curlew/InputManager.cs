#region Using
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input; 
#endregion

namespace Curlew
{
    public class InputManager : GameComponent
    {
        #region Fields/Properties
        private static KeyboardState kbState;
        private static KeyboardState lastKbState; 
        #endregion

        #region Constructors
        public InputManager(Game game)
            : base(game)
        {
        } 
        #endregion

        #region Methods
        public static void Flush()
        {
            lastKbState = kbState;
        }

        public override void Update(GameTime gameTime)
        {
            lastKbState = kbState;

            kbState = Keyboard.GetState();

            base.Update(gameTime);
        }

        public static bool KeyDown(Keys key)
        {
            return kbState.IsKeyDown(key);
        }

        public static bool KeyReleased(Keys key)
        {
            return kbState.IsKeyUp(key) && lastKbState.IsKeyDown(key);
        }

        public static bool KeyPressed(Keys key)
        {
            return kbState.IsKeyDown(key) && lastKbState.IsKeyUp(key);
        } 
        #endregion
    }
}
