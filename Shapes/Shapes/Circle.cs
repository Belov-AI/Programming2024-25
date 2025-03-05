using System;
using System.Net.NetworkInformation;

namespace Shapes
{
    public class Circle : Shape, ICloneable
    {
        Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public object Clone() => new Circle(Center.Clone() as Point, Radius);

    }
}
