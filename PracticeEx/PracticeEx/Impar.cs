using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
   public static class Impar

    {
        public  static int maxof(int x, int y, int z)
        {
            if (x % 2 != 0 || y % 2 != 0 || z % 2 != 0)
            {
                
                if (x > y && x > z)
                {
                    return x;
                }
                else if (y > x && y > z)
                {
                    return  y;
                }
                else
                {
                    return z;
                }
                           }
            else if (x % 2 == 0 || y % 2 == 0 || z % 2 == 0)

            {
                return 0;
            }

            return 0;
        }
    }
}

