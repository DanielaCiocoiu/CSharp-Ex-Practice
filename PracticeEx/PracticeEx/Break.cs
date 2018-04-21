using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
    class Break
    {
        public  void Run()
        {
            int sum = 0;
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
            }
            foreach(int x in num)
            {
                Console.WriteLine("Valoarea este: " + x);
                sum = +x;
                if (x == 4)
                    break;
                Console.WriteLine("Suma primelor 5 numere este: " + sum);
            }
        }
    }
}
