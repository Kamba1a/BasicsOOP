using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Point
    {
        int x;
        int y;
        char sym;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }

        public Point GetNextPoint(Direction direction)
        {
            Point p;
            if (direction == Direction.UP)
            {
                p = new Point(x, y-1, sym);
            }
            else if (direction == Direction.DOWN)
            {
                p = new Point(x, y+1, sym);
            }
            else if (direction == Direction.LEFT)
            {
                p = new Point(x-1, y, sym);
            }
            else
            {
                p = new Point(x+1, y, sym);
            }
            return p;
        }

        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public bool IsCrossed(Point point)
        {
            return x == point.X && y == point.Y;
        }

        public bool IsCrossed(Line line)
        {
            Point p = new Point(x, y);
            return line.IsCrossed(p);
        }

        public bool IsCrossed(Figure figure)
        {
            Point p = new Point(x, y);
            return figure.IsCrossed(p);
        }
    }
}
