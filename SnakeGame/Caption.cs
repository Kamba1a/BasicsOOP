using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Caption
    {
        int windowWidth;
        int windowHeight;

        public Caption(int windowWidth, int windowHeight)
        {
            this.windowWidth = windowWidth;
            this.windowHeight = windowHeight;
        }

        public void Title(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2 - 2);
            for (int i = 0; i < message.Length; i++) Console.Write("=");
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2 - 1);
            Console.Write(message);
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2);
            for (int i = 0; i < message.Length; i++) Console.Write("=");
            Console.ResetColor();
        }

        public void Title (string message, ConsoleColor fontColor, ConsoleColor decorColor)
        {
            Console.ForegroundColor = decorColor;
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2-2);
            for (int i = 0; i < message.Length; i++) Console.Write("=");
            Console.ForegroundColor = fontColor;
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2 - 1);
            Console.Write(message);
            Console.ForegroundColor = decorColor;
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2);
            for (int i = 0; i < message.Length; i++) Console.Write("=");
            Console.ResetColor();
        }

        public void Subtitle(string message)
        {
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2 + 2);
            Console.Write(message);
        }

        public void Subtitle2(string message)
        {
            Console.SetCursorPosition(windowWidth / 2 - message.Length / 2, windowHeight / 2 + 4);
            Console.Write(message);
        }

        public void Clear()
        {
            for (int i=2; i>=0; i--)
            {
                Console.SetCursorPosition(0, windowHeight / 2 - i);
                for (int j = 0; j < windowWidth; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(0, windowHeight / 2 + 2);
            for (int i = 0; i < windowWidth; i++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(0, windowHeight / 2 + 4);
            for (int i = 0; i < windowWidth; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
