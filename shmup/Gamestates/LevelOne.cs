using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using shmup.Sprites;
using shmup.Sprites.Enemies;
using shmup.Sprites.Bullets;
using shmup.Sprites.Player;

namespace shmup.Gamestates
{
    public static class LevelOne
    {
        private static List<Enemy> _enemies = new List<Enemy>();
        private static int _framesElapsed = 0;
        private static int _secondsElapsed = 0;


        static void Start()
        {

        }

        static void Update()
        {
            switch (_secondsElapsed)
            {
                case 8:
                    switch (_framesElapsed)
                    {
                        // arbitrary numbers
                        case 0:
                            _enemies.Add(new Enemy01() { Velocity = 5f, Origin = new Vector2(10f, 10f) });
                            break;
                        case 30:
                            _enemies.Add(new Enemy01() { Velocity = -5f, Origin = new Vector2(-10f, -10f) });
                            break;
                        case 60:
                            _enemies.Add(new Enemy01() { Velocity = 5f, Origin = new Vector2(10f, 10f) });
                            break;
                    }
                    break;
            }

            _framesElapsed++;
            if (_framesElapsed == 10)
            {
                _framesElapsed = 0;
                _secondsElapsed++;
            }
        }

    }

}

