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
            Point p1 = new Point(3, 4, '*');
            p1.Draw();

            Point p2 = new Point(6, 7, '#');
            p2.Draw();

            Point p3 = new Point(4, 5, '&');
            p3.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 10, 7, '*');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(3, 8, 12, '*');
            vLine.Draw();

            Console.ReadKey();
        }
    }
}
