using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace AACmono
{
    class Grid
    {
        private int wResolution = 0;
        private int lResolution = 0;
        private int size = 0;
        private int sqaureSize = 0;
        private Tile[] GridArr;
        public int GridIndex = 0;
        public Grid(int screenWidth, int screenLength, int tileSize)
        {
            //make Grid dynamic later with a count variable  with resolution
            wResolution = screenWidth;
            lResolution = screenLength;
            sqaureSize = tileSize;
            size = (int)(wResolution * .01) * (int)(lResolution * .01) + 2; // +2 because it starts at 1 instead of 0, and because the extra tile is added in da end
            GridArr = new Tile[size];

        }

        public void initializeGrid()
        {
            int w = (int)(wResolution * .01);
            int l = (int)(lResolution * .01);
            //make dynamic with resolution ? later later
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    GridIndex++;
                    GridArr[GridIndex] = new Tile(new Vector2(i * sqaureSize, j * sqaureSize), "ground");
                    Debug.WriteLine(GridArr[GridIndex].pos);
                    Debug.WriteLine(GridIndex);
                }
            }
            GridArr[GridIndex+1] = new Tile(new Vector2(wResolution, lResolution), "ground");
            GridIndex++;
            Debug.WriteLine(GridArr[GridIndex].pos);
            Debug.WriteLine(GridIndex);

            Debug.WriteLine("this is the logical size");
            Debug.WriteLine(GridIndex+1); //+1 because [0] is empty
            Debug.WriteLine("this is the physical size");
            Debug.WriteLine(size);
        }

        //make detecting and other methods soon  like set type of this at index

        public Tile[] getArray()
        {
            return GridArr;
        }

        public int getSize()
        {
            return size;
        }


    }
}
