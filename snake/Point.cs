using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym  { get; set; }

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

        public void Clear()
        {
            Sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        public bool IsHit(Point p)
        {
            return (p.X == X) && (p.Y == Y);
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
