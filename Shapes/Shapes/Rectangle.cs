using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Point TopLepft {get; set;}
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
