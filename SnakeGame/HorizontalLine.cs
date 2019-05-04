﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class HorizontalLine :Line
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            for (int i = xLeft; i<=xRight; i++)
            {
                Point p = new Point(i, y, sym);
                pointsList.Add(p);
            }
        }
    }
}
