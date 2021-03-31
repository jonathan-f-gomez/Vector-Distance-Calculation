using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Distance_Calculation
{
    public struct ThreePoints
    {
        public int x, y, z;

        public ThreePoints(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public ThreePoints(Random point)
        {
            this.x = point.Next(1, 1001);
            this.y = point.Next(1, 1001);
            this.z = point.Next(1, 1001);
        }
    }
}
