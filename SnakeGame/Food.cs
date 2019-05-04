using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Food
    {
        int fieldWidth;
        int fieldHeight;
        char sym;
        ConsoleColor color;

        public Food(int windowWidth, int windowHeight, char sym, ConsoleColor color)
        {
            fieldWidth = windowWidth-2;
            fieldHeight = windowHeight-3;
            this.sym = sym;
            this.color = color;
        }

        public Point Create()
        {
            Random random = new Random();
            Point food = new Point(random.Next(1, fieldWidth+1), random.Next(1, fieldHeight+1), sym);
            Console.ForegroundColor = color;
            food.Draw();
            Console.ResetColor();
            return food;
        }
    }
}
