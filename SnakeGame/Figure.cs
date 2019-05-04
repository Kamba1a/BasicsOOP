using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Figure
    {
        protected List<Line> linesList = new List<Line>();

        public void Draw()
        {
            foreach (Line l in linesList)
            {
                l.Draw();
            }
        }

        public bool IsCrossed(Point point)
        {
            foreach (Line l in linesList)
            {
                if (l.IsCrossed(point))
                { return true; }
            }
            return false;
        }
    }
}
