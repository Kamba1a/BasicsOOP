using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    class Snake :Line
    {
        Direction direction;
        Point tail;
        Point head;
        ConsoleColor color;

        public Direction Direction { get { return direction; } }

        public Point Head { get { return head; } }

        public Line Body
        {
            get
            {
                MyTestLine body = new MyTestLine(pointsList);
                body.RemoveLastPoint();
                return body;
            }
        }

        public Snake(Point tail, int size, Direction direction, ConsoleColor color)
        {
            this.direction = direction;
            this.tail = tail;
            this.color = color;

            pointsList.Add(tail);
            Point p = tail.GetNextPoint(direction);
            for (int i = 1; i < size; i++)
            {
                pointsList.Add(p);
                p = p.GetNextPoint(direction);
            }
            head = pointsList.Last();
            Console.ForegroundColor = color;
            Draw();
            Console.ResetColor();
        }

        public void Move()
        {
            pointsList.Add(head.GetNextPoint(direction));
            pointsList.Remove(tail);
            tail.Clear();
            tail = pointsList.First();
            head = pointsList.Last();
            Console.ForegroundColor = color;
            head.Draw();
            Console.ResetColor();
        }

        public void directionChanger(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow && direction!=Direction.DOWN)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow && direction != Direction.UP)
            {
                direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow && direction != Direction.LEFT)
            {
                direction = Direction.RIGHT;
            }
        }

        public void Eat()
        {
            pointsList.Add(head.GetNextPoint(direction));
            head = pointsList.Last();
            Console.ForegroundColor = color;
            head.Draw();
            Console.ResetColor();
        }
    }
}
