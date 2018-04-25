using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Exercitii
{
   public class AccesSpecifier
    {
        private static int num1, num2, result;
        public void Add()
        {
            result = num1 + num2;
            Console.WriteLine("\n\nAdd = {0} ", result);
        }
        public int Number1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }
        public int Number2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }
       
    }
    class Execute
    {
        public static void Run()
        {
            AccesSpecifier input = new AccesSpecifier();
            Console.Write("Enter number 1st:\t");
            input.Number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 1st:\t");
            input.Number2 = int.Parse(Console.ReadLine());
            input.Add();
        }
    }
}
