﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Point[] points = ReadPoints();
            Point[] closestTwoPoints = GetClosestTwoPoints(points);

            PrintDistance(closestTwoPoints);
            PrintPoint(closestTwoPoints[0]);
            PrintPoint(closestTwoPoints[1]);

        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X,point.Y);
        }

        private static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");
        }

        private static Point[] GetClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            for (int p2 = p1 + 1; p2 < points.Length; p2++)
            {
                    double distance = CalcDistance(points[p1], points[p2]);

                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }

            return closestTwoPoints;
        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();

            }
            return points;
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private static Point ReadPoint()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point();

            point.X = input[0];
            point.Y = input[1];

            return point;
        }
    }
}