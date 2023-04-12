using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box
    {
        private const double BoxMinValue = 0;
       
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= BoxMinValue)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= BoxMinValue)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
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
                if (value <= BoxMinValue)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
            => (2 * this.Length * this.Width) + (2 * this.Height * this.Length) + (2 * this.Width * this.Height);

        public double LateralSurfaceArea()
            => (2 * this.Height * this.Length) + (2 * this.Width * this.Height);

        public double Volume()
            => this.Length * this.Width * this.Height;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Surface Area - {SurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
