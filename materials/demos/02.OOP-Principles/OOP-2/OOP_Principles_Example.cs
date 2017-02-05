using System;
using MathUtilities;

namespace OOP_2
{
    struct Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
    }

    /*class Triangle
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width should be positive");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height should be positive");
                }
                this.height = value;
            }
        }
        
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        internal double Area
        {
            get
            {
                return this.width * this.height / 2;
            }
        }
    }*/


    class OOP_Principles_Example
    {
        static void Main()
        {
            Triangle abc = new Triangle(20, 10);
            abc.Width = 20;
            abc.Height = 10;

            //Console.WriteLine(abc.Area);
        }

    }
}
