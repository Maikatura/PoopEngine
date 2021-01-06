using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using PoopEngine.ECS;

namespace PoopEngine
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D test;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();


            var test123 = Entity.CreateEntity("Test");
            
            var sprite = new Sprite(test);

            test123.AddComponent(new SpriteRenderer(sprite));

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Graphics.Instance.Batcher = _spriteBatch;

            
            // TODO: use this.Content to load your game content here
            test = Content.Load<Texture2D>("Male_Idle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            CompHandler.Instance.Update(gameTime);
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Graphics.Instance.Batcher.Begin();
            CompHandler.Instance.Draw(gameTime);
            Graphics.Instance.Batcher.End();
            
            base.Draw(gameTime);
            
            
        }
    }
}
