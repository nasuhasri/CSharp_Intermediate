﻿using System;

namespace Classes
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // defensive programming
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            Move(newLocation.X, newLocation.Y);

            //this.X = newLocation.X;
            //this.Y = newLocation.Y;
        }
    }
}
