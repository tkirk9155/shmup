using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using shmup.Sprites;
using shmup.Sprites.Enemies;
using shmup.Sprites.Bullets;
using shmup.Sprites.Player;
using System.Collections.Generic;

namespace shmup
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        //private Sprite _playerOne;
        private Player _playerOne;
        private List<Sprite> _sprites;
        //private CollisionGrid _grid;
        //private List<Sprite>[,] _grid;
        private CollisionGrid _grid;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }



        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }



        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            var texture = Content.Load<Texture2D>("ship01");
            var bulletTexture = Content.Load<Texture2D>("shot02");
            _playerOne = new Player(texture)
            {
                Position = new Vector2(100, 100),
                Velocity = 3f,
                Bullet = new Bullet(bulletTexture)
            };
            _sprites = new List<Sprite>()
            {
                _playerOne
            };
            _grid = new CollisionGrid();
            
        }



        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }




        protected override void Update(GameTime gameTime)
        {
            _grid.Clear();

            foreach (var sprite in _sprites.ToArray())
            {
                _grid.Add(sprite);
                sprite.Update(gameTime, _sprites, _grid);
            }

            base.Update(gameTime);
        }





        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            foreach (var sprite in _sprites)
                sprite.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }


    }
}
