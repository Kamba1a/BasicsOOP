using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class MyTestLine :Line
    {
        Point point1;
        Point point2;
        char sym;

        public MyTestLine(List<Point> pointsList)
        {
            foreach (Point p in pointsList)
            {
                this.pointsList.Add(p);
            }
        }

        public MyTestLine(Point point1, Point point2, char sym)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.sym = sym;
            ListAdd();
        }

        void ListAdd()
        {
            if (LineIsHorizontal())
            {
                for (int i = point1.X; i <= point2.X; i++)
                {
                    Point p = new Point(i, point1.Y,sym);
                    pointsList.Add(p);
                }
            }
            else
            {
                for (int i = point1.Y; i <= point2.Y; i++)
                {
                    Point p = new Point(point1.X,i,sym);
                    pointsList.Add(p);
                }
            }
        }

        bool LineIsHorizontal()
        {
            return point1.X < point2.X;
        }
    }
}
