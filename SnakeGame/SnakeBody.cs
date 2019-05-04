using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class SnakeBody :Line
    {
        public SnakeBody(List<Point> pointsList)
        {
            foreach (Point p in pointsList)
            {
                this.pointsList.Add(p);
            }
        }

        public void RemoveLastPoint()
        {
            pointsList.Remove(pointsList.Last());
        }
    }
}
