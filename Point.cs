/*
**  AUTHOR      :   Robert James Patterson
**  DATE        :   01/07/18
**  FILE        :   TreehouseDefense/Point.cs
**  SYNOPSIS    :   Team Treehouse C# Objects course work files
**
*/
using System;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;
        
        // Constructor for the Point() class
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
      
      
      // Find the distance between two points in a plane with Cartesian coordinates
      public int DistanceTo(int x, int y)
      {
          int xDiff = X - x;
          int yDiff = Y - y;
        
          int xDiffSquared = xDiff * xDiff;
          int yDiffSquared = yDiff * yDiff;
        
          return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
          /* 
          **  NOTE: This could have also been written on one line as follows:
          **
          **  return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
          **  
          */
      }
            
      public int DistanceTo(Point point)
      {
          return DistanceTo(point.X, point.Y);
      }
    }
}