using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Exercitii
{
    public class Prime
    {
        public static void PrimeNum()
        { 
        bool isNumberComposite = false;
        int j;
        Console.WriteLine("Enter your number");
            int target = Int32.Parse(Console.ReadLine());
            for (int i = 2; i <= target; i++)
            {
                for ( j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isNumberComposite = true;
                        break;
                    }
                }
                if (!isNumberComposite)
                {
                    Console.WriteLine("{0}", j);

                }
                else
                {
                    isNumberComposite =false;
                }
            }

        }
}}