﻿using System;
namespace Rectangle
{
    public class Rectangle
    {
        double width, height;

            public Rectangle()
            {
            }
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public double GetArea()
            {
                return this.width * this.height;
            }

            public double GetPerimeter()
            {
                return (this.width + this.height) * 2;
            }

            public string Display()
            {
                return "width = " + width + ", height = " + height;
            }
    }
}


