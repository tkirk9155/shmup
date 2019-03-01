﻿using System;
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

namespace shmup.Sprites.Enemies
{
    class Enemy : Sprite
    {
        public Enemy(Texture2D texture)
            : base(texture)
        {

        }

    }
}
