﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }


        public static Point operator /(Point a, Point b)
        {
            return new Point(a.X / b.X, a.Y / b.Y);
        }

        public static Point operator *(Point a, Point b)
        {
            return new Point(a.X * b.X, a.Y * b.Y);
        }


        public void Print()
        {
            Console.WriteLine($"{X} {Y}");
        }
    }
}
