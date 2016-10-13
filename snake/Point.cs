using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        int X { get; set; }
        int Y { get; set; }
        char Sym  { get; set; }

        public Point() { }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT)
                X -= offset;
            else if (direction == Direction.RIGHT)
                X += offset;
            else if (direction == Direction.UP)
                Y -= offset;
            else if (direction == Direction.DOWN)
                Y += offset;
        }
    }
}
