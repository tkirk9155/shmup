using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using shmup.Sprites;


namespace shmup
{
    class CollisionGrid
    {
        public class Square
        {
            public List<Sprite> SpriteList = new List<Sprite>();
            public bool Check = false;
        }

        public Square[,] Squares = new Square[,]
        {
            {new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square()},
            {new Square(), new Square(), new Square(), new Square(), new Square()}
        };
    }
}
