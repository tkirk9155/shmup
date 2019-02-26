using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using shmup.Sprites;
using shmup.Sprites.Bullets;
using System.Drawing;

namespace shmup
{
    class CollisionGrid
    {
        private int _resX;
        private int _resY;
        /// <summary>
        /// 0 = enemy, 1 = player
        /// </summary>
        public class Square
        {
            public List<Sprite> Sprites = new List<Sprite>();
            public bool Check = false;
        }

        public Square[,] Squares;

        public void New(int resX, int resY)
        {
            _resX = resX;
            _resY = resY;
            Clear();
        }

        public void Clear()
        {
            Squares = null;
            Squares = new Square[,]
            {
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()},
                { new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square(), new Square()}
            };
        }


        public void Add(Sprite sprite)
        {

            int gX = (int)(System.Math.Floor(sprite.Position.X) / 10);
            int gY = (int)(System.Math.Floor(sprite.Position.Y) / 10);

            Squares[gX, gY].Sprites.Add(sprite);
            if (sprite.CheckGrid)
                Squares[gX, gY].Check = true;
        }


        public void CheckCollisions()
        {
            int gX = 0;
            int gY = 0;

            while (gY < 10)
            {
                while (gX < 10)
                {
                    if (Squares[gX, gY].Check)
                    {
                        foreach(Sprite ship in Squares[gX, gY].Sprites.Where(s => !s.IsRemoved && !s.Bullet))
                        {
                            Rectangle currentRect = new Rectangle((int)ship.Position.X, (int)ship.Position.Y, ship.Width, ship.Height);
                            foreach(Bullet bullet in Squares[gX, gY].Sprites.Where(b => !b.IsRemoved && b.Enemy != ship.Enemy))
                            {
                                if (new Rectangle((int)ship.Position.X, (int)ship.Position.Y, ship.Width, ship.Height).IntersectsWith(currentRect))
                                    ship.Health -= bullet.Damage;
                            }
                        }
                    }
                    gX++;
                }
                gY++;
                gX = 0;
            }
        }


    } 
}
