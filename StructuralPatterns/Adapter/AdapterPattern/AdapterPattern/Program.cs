using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>() { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };

            int x1 = 10, y1 = -5, x2 = 7, y2 = -3;

            shapes.ForEach(shape => shape.Draw(x1, y1, x2, y2));
            Console.Read();
        }
    }
}
