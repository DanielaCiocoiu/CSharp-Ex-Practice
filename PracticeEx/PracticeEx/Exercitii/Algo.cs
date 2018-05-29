using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Exercitii
{
    public class Algo
    {
        public static void Pattern()
        {

            for (int i = 1; i <= 6; i++)//cifre
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = 6; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 6; i >= 1; i--)//4 cifre
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                for (int k = 6; k >= i; k--)//1
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
