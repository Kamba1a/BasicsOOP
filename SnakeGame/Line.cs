using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Line
    {
        protected List<Point> pointsList = new List<Point>();


        public void Draw()
        {
            foreach (Point p in pointsList)
            {
                p.Draw();
            }
        }

        public bool IsCrossed(Point point)
        {
            foreach (Point p in pointsList)
            {
                if (point.IsCrossed(p)) return true;
            }
            return false;
        }

        public void RemoveLastPoint()
        {
            pointsList.Remove(pointsList.Last());
        }
    }
}
