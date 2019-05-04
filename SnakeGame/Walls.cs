using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Walls :Figure
    {
        HorizontalLine wallTop;
        HorizontalLine wallBottom;
        VerticalLine wallLeft;
        VerticalLine wallRight;

        public Walls (int windowWidth, int windowHeight, char sym)
        {
            wallTop = new HorizontalLine(1, windowWidth-2, 0, sym);
            wallBottom = new HorizontalLine(1, windowWidth-2, windowHeight-1, sym);
            wallLeft = new VerticalLine(1, windowHeight - 2, 0, sym);
            wallRight = new VerticalLine(1, windowHeight - 2, windowWidth - 1, sym);

            ListAdd();

            Draw();
        }

        public Walls(int windowWidth, int windowHeight, char sym, ConsoleColor color)
        {
            wallTop = new HorizontalLine(1, windowWidth - 2, 0, sym);
            wallBottom = new HorizontalLine(1, windowWidth - 2, windowHeight - 1, sym);
            wallLeft = new VerticalLine(1, windowHeight - 2, 0, sym);
            wallRight = new VerticalLine(1, windowHeight - 2, windowWidth - 1, sym);

            ListAdd();

            Console.ForegroundColor = color;
            Draw();
            Console.ResetColor();
        }

        void ListAdd()
        {
            linesList.Add(wallTop);
            linesList.Add(wallBottom);
            linesList.Add(wallLeft);
            linesList.Add(wallRight);
        }
    }
}
