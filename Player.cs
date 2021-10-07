using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace AACmono
{
    class Player
    {
        public Vector2 pos;
        public int pn = 0; //playernumber
        public int t = 0; //team
        public string stat;
        public int speed;

        public bool fire;

        public Player(Vector2 pospara, int pnpara)
        {
            pos = pospara;
            pn = pnpara;

            stat = "normal";
            speed = 100;

            fire = false;
            //work here implement player 2 and keys
        }

        public Player(Vector2 pospara, int pnpara, int tpara)
        {
            pos = pospara;
            pn = pnpara;
            t = tpara;

            stat = "normal";
            speed = 15;

            fire = false;
            //work here implement player 2 and keys


        }

        void playerControl(GameTime gameTime)
        {
            //Debug.WriteLine(p1.getPos());

            KeyboardState kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Up))
                pos.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds; //multiplied by amount of time passed since last update call

            if (kstate.IsKeyDown(Keys.Down))
                pos.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Left))
                pos.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Right))
                pos.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

        }

        bool tileCheck(GameTime gameTime)
        {
            //for
            return false;
        }
        
        //The method to be looped in update, If the method is to be looped, put in this method
        public void loopGroup(GameTime gameTimeLG)
        {
            playerControl(gameTimeLG);
            tileCheck(gameTimeLG);
        }

        //information returning methods
        public string getPos()
        {
            return $" xy : ({pos})";
        }



        //IsKeyDown(Keys.Escape)
    }
}
