using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Challenge2.BL;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[5, 3] { { '*', ' ', ' ' }, { '*', '*', ' ' }, { '*', '*', '*' }, { '*', '*', ' ' }, { '*', ' ', ' ' } };
            char[,] optriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };
            Boundary Bound = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            GameObject Game1 = new GameObject(triangle, new Point(5, 5), Bound, "LeftToRight");
            GameObject Game2 = new GameObject(optriangle, new Point(10, 10), Bound, "Patrol");
            List<GameObject> obj = new List<GameObject>();
            obj.Add(Game1);
            obj.Add(Game2);
            while (true)
            {
                Thread.Sleep(100);
                foreach (var G in obj)
                {
                    G.Erase();
                    G.Draw();
                    G.Move();
                }
            }
        }
    }
}
