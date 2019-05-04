using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int windowWidth = 100;
            int windowHeight = 50;

            Console.SetBufferSize(windowWidth, windowHeight);
            Console.SetWindowSize(windowWidth, windowHeight);
            Console.CursorVisible = false;

            Caption caption = new Caption(windowWidth, windowHeight);
            caption.Title("ДОБРО ПОЖАЛОВАТЬ В ИГРУ \"ЗМЕЙКА\"!");
            caption.Subtitle("Нажмите любую клавишу, чтобы начать.");
            Console.ReadKey(true);
            caption.Clear();
            
            Walls walls = new Walls(windowWidth, windowHeight, '#');

            Point snakeTailStartPosition = new Point(windowWidth/2, windowHeight/2, '*');
            Snake snake = new Snake(snakeTailStartPosition, 5, Direction.RIGHT, ConsoleColor.Green);

            Food food = new Food(windowWidth, windowHeight, '@', ConsoleColor.Yellow);
            Point foodPozition = food.Create();


            int snakeSpeed = 150;
            int gameCount = 0;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.directionChanger(key.Key);
                }
                snake.Move();
                if (snake.Head.IsCrossed(foodPozition))
                {
                    snake.Eat();
                    foodPozition = food.Create();
                    snakeSpeed = snakeSpeed - (snakeSpeed/10);
                    gameCount++;
                }
                if (snake.Head.IsCrossed(walls) || snake.Head.IsCrossed(snake.Body)) break;

                if (snake.Direction == Direction.UP || snake.Direction == Direction.DOWN) Thread.Sleep((int)(snakeSpeed*1.25));
                else Thread.Sleep(snakeSpeed);
            }

            caption.Title($"Ваш счет: {gameCount}. Спасибо за игру!");
            caption.Subtitle("Игра сделана Ольгой Н.");
            caption.Subtitle2("в рамках прохождения курса GeekBrains \"Основы ООП\"");

            while (true) Console.ReadKey(true);
        }
    }
}
