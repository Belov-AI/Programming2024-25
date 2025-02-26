using System.Drawing;

namespace Shapes
{
    public abstract class Shape
    {
        public Color FillColor;
        public Color OutlineColor;

        public abstract void Draw();
    }
}
