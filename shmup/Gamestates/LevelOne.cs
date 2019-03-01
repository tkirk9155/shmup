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
        private static List<Enemy> _enemies = new List<Enemy>()
        {
            new Enemy(Textures.enemy01);
        }

        static void Start()
        {

        }
    }
}
