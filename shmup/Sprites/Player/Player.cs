using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using shmup.Sprites.Bullets;
using shmup.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shmup.Sprites.Player
{
    class Player : Sprite
    {
        public Bullet Bullet;
        protected KeyboardState _previousKey;
        protected KeyboardState _currentKey;
        
        public Player(Texture2D texture)
            : base(texture)
        {

        }



        public override void Update(GameTime gameTime, 
            List<Sprite> sprites, 
            CollisionGrid grid)
        {
            //base.Update(gameTime, sprites);
            _previousKey = _currentKey;
            _currentKey = Keyboard.GetState();

            //Direction = new Vector2((float)Math.Cos(_))
            if (_currentKey.IsKeyDown(Keys.Up))
                Position.Y -= Velocity;
            if (_currentKey.IsKeyDown(Keys.Down))
                Position.Y += Velocity;
            if (_currentKey.IsKeyDown(Keys.Left))
                Position.X -= Velocity;
            if (_currentKey.IsKeyDown(Keys.Right))
                Position.X += Velocity;
            if (_currentKey.IsKeyDown(Keys.Space) &&
                _previousKey.IsKeyUp(Keys.Space))
            {
                var bullet = Bullet.Clone() as Bullet;
                bullet.Direction = this.Direction;
                bullet.Position = this.Position;
                bullet.Velocity = this.Velocity * 2;
                bullet.Lifespan = 2f;
                bullet.Parent = this;

                sprites.Add(bullet);
            }

            int gX = (int)Position.X / 10;
            int gY = (int)Position.Y / 10;

        }
    }
}
