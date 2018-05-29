using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeEx.Exercitii
{
    public class Ex
    {
        public static void SimpleMethod(int j)
        {
            j = 101;
        }
        public static void EvenNumber()
        {
            int start = 0;
            while(start <20)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
        public static void Fibonacci()
        {
            int n, first = 0, second = 1, third;

            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("First {0} Fibonaci number {1} {2}", n, first, second);
            for (int i = 3; i < n; i++)
            {
                third = first + second;
                Console.Write("{0}", third);
                first = second;
                second = third;

            }
        }
        public static void Fibonacci1()
        {
            Console.WriteLine("Fib 1, Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1;
            int secondNumber = 1;
            int fibonacci;
            for (int i = 2; i < n; i++)
            {
                fibonacci = firstNumber + secondNumber;
                secondNumber = firstNumber;
                firstNumber = fibonacci;
                Console.WriteLine("Fibonacci {0} = {1} ", i, fibonacci);
            }
        }
        public static int Fibonacci2(int n)
        {
            //n = number of fib
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;

        }
        public static void Pattern()
        {
            int i, j;
            i = 0;
            j = 0;

            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        public static void FizzBuzz()
        {
            //3 - Fizz;
            //5 = Buzz;
            //15 = FizzBuzz;

            for (int i = 0; i < 300; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void FibonacciStreamWriter()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "fibonacciwriter.txt";
            string fullPath = Path.Combine(directory, filename);
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(fullPath, false))
                {
                    int a = 1;
                    int b = 0;
                    for (int i = 0; i < 25; i++)
                    {
                        streamWriter.WriteLine(b); //va porni de la 0
                        a = a + b;
                        b = a - b;

                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }

        }
        public static void Fib3()
        {
            int a = 1;
            int b = 0;
            int n = 25;

            for (int i = 0; i < n; i++)
            {
                a = a + b;
                b = a - b;
                Console.WriteLine(b);
            }

        }
        public static void inmultire()
        {
            int sum = 0;
            int a = 10;
            int b = 4;
            for (int i = 0; i < b; i++)
            {
                sum = sum * a;
                Console.WriteLine("{0} * {1} = {2}", a, b, sum);
            }
        }
        public static void ariaCerc()
        {
            double raza = 7.5;

            Console.WriteLine("Perimetrul cercului este: " + (2 * Math.PI * raza));
            Console.WriteLine("Aria cercului este: " + (Math.PI * Math.Pow(raza, 2)));

        }

        public static void average()
        {
            const int numere = 4;
            float suma = 0;
            for (int i = 0; i < numere; i++)
            {
                Console.WriteLine("Introducetinumarul: ", (i + 1) + ":");
                int numar = int.Parse(Console.ReadLine());
                suma += numar;
            }
            Console.WriteLine(suma / numere);
        }

        public static void binary()
        {
            Console.WriteLine("Introduceti nr1: ");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti nr2: ");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(nr1 + nr2));
            var IntToBinValue = Convert.ToString(6, 2);
            Console.WriteLine(IntToBinValue);
        }
        public static void doWhile()
        {
           
            Console.WriteLine("Introduceti UserTarget: ");
            int UserTarget = int.Parse(Console.ReadLine());
            int Start = 0;
            while (Start <= UserTarget)
            {
                Console.Write(Start + "");
                Start = Start + 2;
            }
            string userChoice = "";
            do
            {
                Console.WriteLine("Do you want to continue: yes or no: ");
                userChoice = Console.ReadLine().ToUpper();
                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid Choise, please chose YES or NO");
                } 
            } while (userChoice != "YES" && userChoice != "NO");
            while (userChoice == "YES") ;
        }
     

            public static int unghiCeas(int ora, int min)
            {

                int unghiOra = ora * 30;
                int unghiMin = min * 6;
                int unghi = Math.Abs(unghiOra - unghiMin);
                if (unghi <= 180)
                {
                    return unghi;
                }
                else
                {
                    return 360 - unghi;
                }
           // Console.WriteLine("Unghiul dintre cele doua limbi este:{0} ", unghiCeas(11, 12));
        }
        }
    }

   



