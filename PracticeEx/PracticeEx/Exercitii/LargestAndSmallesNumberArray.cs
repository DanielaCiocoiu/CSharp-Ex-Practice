using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
    class LargestAndSmallesNumberArray
    {
        public static void Run()
        {
            float large, small;


            int[] a = new int[5];
            Console.WriteLine("Array element: ");
            for (int i = 0; i < 5; i++)
            {

                string s = Console.ReadLine();
                a[i] = int.Parse(s);

            }
            Console.Write("");
            large = a[0];
            small = a[0];
            for (int i = 1; i < 5; i++)
            {
                if (a[i] > large)
                {
                    large = a[i];
                }
                else if (a[i] < small)
                {
                    small = a[i];
                }
            }
            Console.WriteLine("Largest element in the array is {0}", large);
            Console.WriteLine("Smallest element in the array is {0}", small);
        }
    }
}
