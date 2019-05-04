using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class VerticalLine :Line
    {
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, sym);
                pointsList.Add(p);
            }
        }
    }
}
