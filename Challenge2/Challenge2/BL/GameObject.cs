using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class GameObject
    {
        public char[,] Shape;
        public Point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public GameObject()
        {
            Shape = new char[1, 3] { { '-', '-', '-' } };
            StartingPoint = new Point();
            Premises = new Boundary();
            Direction = "LeftToRight";
        }
        public GameObject(char[,] Shape,Point StartingPoint, Boundary Premises, string Direction )
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = new Boundary();
            this.Direction = Direction;
        }
        public void Draw()
        {
            int x = StartingPoint.x ;
            int y = StartingPoint.y ;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.Write(Shape[i, j]);
                }
                y++;
            }
           Console.BackgroundColor =  ConsoleColor.White;
        }
        public void Erase()
        {
            int x = StartingPoint.x;
            int y = StartingPoint.y;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y);
                for (int j = 0; j < Shape.GetLength(1); j++)
                {
                    Console.Write(" ");
                }
                y++;
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Move()
        {
            if (Direction == "LeftToRight" && (StartingPoint.x > 0 && StartingPoint.x < 90) && (StartingPoint.y > 0 && StartingPoint.y < 90))
            {
                StartingPoint.x++;
            }
            if (Direction == "RightToLeft" && (StartingPoint.x > 0 && StartingPoint.x < 90) && (StartingPoint.y > 0 && StartingPoint.y < 90))
            {
               StartingPoint.x --;
            }
            if (Direction == "Patrol" && (StartingPoint.x > 0 && StartingPoint.x < 90) && (StartingPoint.y > 0 && StartingPoint.y < 90))
            {
                int x = StartingPoint.x;
                bool patrolDirectionRight = false;
                if (patrolDirectionRight)
                {
                    StartingPoint.x ++;
                    if (StartingPoint.x >= Console.WindowWidth)
                    {
                        patrolDirectionRight = false;
                        StartingPoint.x = Console.WindowWidth + x;
                    }
                }
                else
                {
                    StartingPoint.x--;
                    if (StartingPoint.x < 0)
                    {
                        patrolDirectionRight = true;
                        StartingPoint.x = 0;
                    }
                }
            }
           
             
            }
        }


    }

