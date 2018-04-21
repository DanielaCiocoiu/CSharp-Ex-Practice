using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
    class ArrayListEx
    {
        public static void Run()
        {
            ArrayList al = new ArrayList();

            al.Add("Ana");
            al.Add("Maia");
            al.Add("Mia");

            Console.WriteLine("Contents of ArrayList: ");

            foreach (String str in al)
            {
                Console.WriteLine("\n" + str);

            }
            Console.ReadLine();
        }

        
    }
}
