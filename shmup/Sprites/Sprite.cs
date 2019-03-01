using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shmup;

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
        //public bool Enemy = false;
        //public bool Bullet = false;
        public bool CheckGrid = false;
        public SpriteType Type;
        
        public int Health
        {
            get { return Health; }
            set
            {
                Health = value;
                if (Health <= 0)
                    IsRemoved = true;
            }
        }

        public int Width
        { get { return _texture.Width; } }
        public int Height
        { get { return _texture.Height; } }



        public Sprite(Texture2D texture)
        {
            _texture = texture;
            Origin = new Vector2(_texture.Width / 2, _texture.Height / 2);
        }

        

        public virtual void Update(GameTime gameTime, List<Sprite> sprites, CollisionGrid grid, Rectangle screenBounds)
        {
            //if ((Position.X + Width) > screenBounds.Width || Position.X < 0 || (Position.Y + Height) > screenBounds.Height || Position.Y < 0)
            //    IsRemoved = true;
        }


        public virtual bool OffScreen(Rectangle screenBounds)
        {
            return ((Position.X + Width) > screenBounds.Width || 
                Position.X < 0 || 
                (Position.Y + Height) > screenBounds.Height || 
                Position.Y < 0);
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, null, Color.White, 0f, Origin, 1, SpriteEffects.None, 0);
        }



        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public enum SpriteType : int
        {
            Player = 0,
            PlayerBullet = 1,
            Enemy = 2,
            EnemyBullet = 3,
            Powerup = 4
        }
    }

}
