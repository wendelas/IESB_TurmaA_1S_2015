using System;

namespace ClassesEConstrutores
{
    public class Points
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Points()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Points(int x)
            : this()
        {
            this.X = x;
        }

        public Points(int x, int y)
            : this(x)
        {
            this.Y = y;
        }

        public void AddToX(int x)
        {
            this.X += x;
        }

        public void SubtractToX(int x)
        {
            this.X -= x;
        }

        public void AddToY(int y)
        {
            this.Y += y;
        }

        public void SubtractToY(int y)
        {
            this.Y -= y;
        }

        public void Print()
        {
            Console.WriteLine($"X: {this.X} & Y: {this.Y}");
        }
    }
}
