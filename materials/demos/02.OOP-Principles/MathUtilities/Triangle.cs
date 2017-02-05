using System;

namespace MathUtilities
{
    public class Triangle
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
    }
}
