using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Distance_Calculation
{
    public struct Points
    {
        public int x, y;

        public Points(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Points(Random point)
        {
            this.x = point.Next(1, 101);
            this.y = point.Next(1, 101);
        }
    }
    
}
