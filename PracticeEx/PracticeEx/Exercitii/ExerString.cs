using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Exercitii
{
    public static class ExerString
    {

        public static bool IsPrimaryColor(this string inString)
        {
            string[] primaryColor = { "Red", "Yellow", "Blue" };
            foreach (var color in primaryColor)
            {
                if (inString.Equals(color, StringComparison.CurrentCultureIgnoreCase))
                    return true;
            }
            return false;
        }



        public static void reverseString()
        {
            string original = "Token A^ *!% ~Token B ^ *!% ~Token C ^ *!% ~Token D ^ *!% ~Token E";
            string[] separator = new string[1];
            separator[0] = "^*!%~";
            string[] arrayIndividualString = original.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int lungimeaAreiuluideString = arrayIndividualString.Length;
            StringBuilder stringIesire = new StringBuilder();
            for (int i = (lungimeaAreiuluideString - 1); i >= 0; i--)
            {
                stringIesire.Append(arrayIndividualString[i] + separator[0]);
            }
            Console.WriteLine("Original String : " + original);
            Console.WriteLine("Output String : " + stringIesire.ToString());
            Console.ReadLine();
        }
        
    }
}