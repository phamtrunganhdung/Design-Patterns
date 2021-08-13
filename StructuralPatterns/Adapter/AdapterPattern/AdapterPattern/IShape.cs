using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface IShape
    {
        void Draw(int x1, int y1, int x2, int y2);
    }
}
