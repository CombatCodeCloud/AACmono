using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace AACmono
{
    public class Game1 : Game
    {

        //ctx.fillRect(0, 0, 1600, 1000);

        //TODO: add movements//input logic
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Player p1;
        private Grid gridObj;
        private Tile[] gridArr;


        //logic if tile set status of player


        Texture2D greenTankTexture;
        Texture2D tileTexture;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            p1 = new Player(new Vector2(1,2),1);
            gridObj = new Grid(1600, 1000, 100);
            gridObj.initializeGrid();

            _graphics.PreferredBackBufferWidth = 1600;
            _graphics.PreferredBackBufferHeight = 1000;
            _graphics.ApplyChanges();


            gridArr = gridObj.getArray();
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            greenTankTexture = Content.Load<Texture2D>("0");
            tileTexture = Content.Load<Texture2D>("100");

        }
        


        

        void DrawGrid()
        {
            for (int i = 1; i < gridObj.getSize(); i++) //[0] is empty
            {
                //Debug.WriteLine(gridArr[i].pos);
                _spriteBatch.Draw(tileTexture, gridArr[i].pos, Color.Red) ;
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (p1.pos.X > _graphics.PreferredBackBufferWidth - greenTankTexture.Width / 2)
                p1.pos.X = _graphics.PreferredBackBufferWidth - greenTankTexture.Width / 2;
            else if (p1.pos.X < greenTankTexture.Width / 2)
                p1.pos.X = greenTankTexture.Width / 2;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            p1.loopGroup(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            DrawGrid();
            _spriteBatch.Draw(greenTankTexture, p1.pos, Color.White);

            //_spriteBatch.Draw(
            //greenTankTexture,
            //p1.pos,
            //null,
            //Color.White,
            //0f,
            //new Vector2(greenTankTexture.Width / 2, greenTankTexture.Height / 2),
            //Vector2.One,
            //SpriteEffects.None,
            //0f
            //);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
