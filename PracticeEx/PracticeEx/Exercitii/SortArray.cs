using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
    class SortArray
    {
        public static void Run()
        {
            int[] ar = { 1, 5, 6, 8, 9, 10, 11, 44, 50 };
            Console.WriteLine("Original Array: ");

            foreach (int a in ar)
                Console.WriteLine(a);

            Array.Reverse(ar);
            Console.WriteLine("Reveresed Array:");

            foreach (int value in ar)
                Console.WriteLine(value);



            Console.ReadLine();


        }
    }
}
