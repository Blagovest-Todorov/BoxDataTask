using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public void CalcSurfaceArea(double length, double width, double height)
        {
            double surfaceArea = 2 * (length * height) + 2 * (width * height) + 2 * (length * width);
            Console.WriteLine($"Surface Area - {surfaceArea:F2}");
        }

        public void CalcLateralSurfaceArea(double length, double width, double height)
        {
            double lateralSurfaceArea = 2 * (length * height) + 2 * (height * width);
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
        }

        public void CalcVolume(double length, double width, double height)
        {
            double volume = length * height * width;
            Console.WriteLine($"Volume - {volume:F2}");
        }
    }
}
