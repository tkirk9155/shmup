using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shmup.Sprites
{
    class Sprite : ICloneable
    {
        protected Texture2D _texture;
        public Vector2 Position;
        public Vector2 Origin;
        public float Velocity = 0f;
        public Vector2 Direction;
        public Sprite Parent;
        public float Lifespan = 0f;
        public bool IsRemoved = false;

        public Sprite(Texture2D texture)
        {
            _texture = texture;
            Origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
        }

        

        public virtual void Update(GameTime gameTime, List<Sprite> sprites, List<Sprite>[,] grid)
        {
            
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, null, Color.White, 0f, Origin, 1, SpriteEffects.None, 0);
        }



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
