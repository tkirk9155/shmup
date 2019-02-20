using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shmup.Sprites.Bullets
{
    class Bullet : Sprite
    {
        private float _timer;


        public Bullet(Texture2D texture)
            : base(texture)
        {
            
        }


        public override void Update(GameTime gameTime, List<Sprite> sprites)
        {
            //base.Update(gameTime, sprites);
            _timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (_timer > Lifespan)
                IsRemoved = true;

            Position.Y -= Velocity;

        }
    }
}
