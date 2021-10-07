using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace AACmono
{
    class Tile
    {
        public Vector2 pos;
        public int tileIndex = 0;
        public string type;
        public Tile(Vector2 pospara, string typepara)
        {
            //make Tile dynamic later with a count variable  with resolution

            //TileArr = new Tile[161];
            pos = pospara;
            type = typepara;

        }
    }
}
