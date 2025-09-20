using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Deneme1
{
    public class Deneme : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D pixelCastleTexture;
        Texture2D targetTexture;
        Sprite spaceIslandSprite;
        public Deneme()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //pixelCastleTexture = Texture2D.FromStream(GraphicsDevice,File.OpenRead("Content\\pixel-castle-fantasy.png"));
            targetTexture = Texture2D.FromStream(GraphicsDevice, File.OpenRead("D://Projeler//Visual_Studio_Deneme//Deneme1//Deneme1//Content//target.png"));
            Texture2D spaceIslandTexture = Texture2D.FromStream(GraphicsDevice, File.OpenRead("D://Projeler//Visual_Studio_Deneme//Deneme1//Deneme1//Content//space-island.png"));
            Vector2 position = new Vector2(100, 100);
            spaceIslandSprite = new Sprite(spaceIslandTexture,position);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.W))
            {
                spaceIslandSprite.Position.Y -= 10 * gameTime.ElapsedGameTime.Milliseconds/1000f;
            }
            if (keyboardState.IsKeyDown(Keys.A))
            {
                spaceIslandSprite.Position.X -= 10 * gameTime.ElapsedGameTime.Milliseconds / 1000f;
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                spaceIslandSprite.Position.Y += 10 * gameTime.ElapsedGameTime.Milliseconds / 1000f;
            }
            if (keyboardState.IsKeyDown(Keys.D))
            {
                spaceIslandSprite.Position.X += 10 * gameTime.ElapsedGameTime.Milliseconds / 1000f;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointWrap);
            _spriteBatch.Draw(targetTexture, Vector2.Zero, Color.White);
            spaceIslandSprite.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
