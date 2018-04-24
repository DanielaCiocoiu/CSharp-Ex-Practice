using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
    class JaggedArray
    {
        public static void Run()
        {
            int[][] jaggedarr = new int[2][];
            jaggedarr[0] = new int[4] { 1, 3, 5, 44 };
            jaggedarr[1] = new int[6] { 2, 5, 9, 10, 55, 60 };
            for (int i = 0; i < jaggedarr.Length; i++)
            {

                Console.WriteLine("Element{0}", i);
                for (int j = 0; j < jaggedarr.Length; j++)
                {
                    Console.WriteLine("{0}{1}", jaggedarr[i][j], j == (jaggedarr[i].Length - 1) ? "" : "");
                }
                Console.WriteLine();
            }


        }
    }
}
