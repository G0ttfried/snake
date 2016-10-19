using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        int MapWidth { get; set; }
        int MapHeight { get; set; }
        char Sym { get; set; }

        Random random = new Random();
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeight;
            Sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, MapWidth - 2);
            int y = random.Next(2, MapHeight - 2);
            return new Point(x, y, Sym);
        }
    }
}
