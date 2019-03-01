using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace shmup
{
    static class Textures
    {
        public static Texture2D enemy01;
        public static Texture2D player01;
        public static Texture2D playerBullet01;

        public static void Load(ContentManager contentManager)
        {
            enemy01 = contentManager.Load<Texture2D>("enemy01");
            player01 = contentManager.Load<Texture2D>("ship01");
            playerBullet01 = contentManager.Load<Texture2D>("shot01");
        }

    }
}
