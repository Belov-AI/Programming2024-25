using System;

namespace Shapes
{
    public class Point : ICloneable
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public object Clone() => MemberwiseClone();
    }
}
