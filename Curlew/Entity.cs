#region Using
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#endregion

namespace Curlew
{
    /// <summary>
    /// The base class for any playable or non-playable character. 
    /// </summary>
    public abstract class Entity
    {
        #region Fields/Properties
        protected Vector2 position;
        protected float speed;
        protected Animation animation;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        public abstract void Update(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }

}
