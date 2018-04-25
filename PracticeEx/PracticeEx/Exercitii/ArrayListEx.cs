using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
   public class ArrayListEx
    {
        public static void Run()//ex1
        {
            ArrayList al = new ArrayList();

            al.Add("Ana");
            al.Add("Maia");
            al.Add("Mia");

            Console.WriteLine("Contents of ArrayList: ");

            foreach (string str in al)
            {
                Console.WriteLine("\n" + str);

            }
            Console.ReadLine();
        }
        //----------------------------------------------------------------
        public static void Run1()//ex2
        {
            int[] rev = { 4, 5, 8, 2, 10 };
            Array.Reverse(rev);
            for (int i = 0; i < rev.Length; i++)
            {
                Console.WriteLine(rev[i] + "");
            }
        }
        //-----------------------------------------------------------------------

        //Sort One Dimensional Array In Descending Order Using Non Static Method.
        public  void SortArray(int[] numarray)
        {
            int swap = 0;
            for (int i = 0; i < numarray.Length; i++)
            {
                for (int j = i + 1; j < numarray.Length; j++)
                {
                    if (numarray[i] <= numarray[j])
                    {
                        swap = numarray[j];
                        numarray[j] = numarray[i];
                        numarray[i] = swap;
                    }
                }
                Console.Write(numarray[i] + " ");
            }
        }

    }
}
