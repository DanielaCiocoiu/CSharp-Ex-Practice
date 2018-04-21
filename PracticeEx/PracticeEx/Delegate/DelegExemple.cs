using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Delegate
{
    public class DelegExemple
    {
        public delegate int calculator(int x, int y);
        public static int Adunare(int a, int b)
        {
            return a + b;
        }
        public static int Scadere(int a, int b)
        {
            return a - b;
        }
        public void Execute()
        {
            calculator c = new calculator(DelegExemple.Adunare);
            Console.WriteLine("Adunarea lui 5 si 10 este: {0}", c(5, 10));
            calculator d = new calculator(DelegExemple.Scadere);
            Console.WriteLine("Scaderea lui 5 din 10 este: {0}", d(4, 10));
        }
    }
}
