﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        int x;
        int y;
        private static int objectCount = 0;
        public Point()
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
            Console.WriteLine("Default constructor called");

        }
        public Point(int x, int y)
        {
            this.x = x;                         //Two separate variable with same name; we help computer distinguish by using "this" key word
            this.y = y;
            objectCount++;
            Console.WriteLine($"x:{x}, y:{y}");

        }

        
        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        
        
        public static int ObjectCount() => objectCount;
    }
}


/******* object.instanceVar
 * 
 * object.instanceVar
 * Class.ClassVar
 * 
 * 
 * **********/
