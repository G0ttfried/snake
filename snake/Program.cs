using snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine hLine = new HorizontalLine(5, 10, 7, '*');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(3, 8, 12, '*');
            vLine.Draw();

            Snak snake = new Snak(new Point(15, 15, '*'), 5, Direction.RIGHT);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
