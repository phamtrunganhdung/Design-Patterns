using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class LegacyLine
    {
        internal void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Drawing line {x1} {y1} {x2} {y2}");
        }
    }
}
