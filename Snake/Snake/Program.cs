﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);

            Point p2 = new Point(4, 5, '#');
            p2 = p1;

            Console.WriteLine("p2.x = " + p2.x);
            Console.WriteLine("p2.y = " + p2.y);
            Console.WriteLine("p2.sym = " + p2.sym);
            Console.WriteLine();
            //p2.Draw();

            Console.WriteLine("p1.x = " + p1.x);
            Console.WriteLine("p1.y = " + p1.y);
            Console.WriteLine("p1.sym = " + p1.sym);
            //p1.Draw();

            Console.ReadLine();

            
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }

    }   
}
