using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Delegate
{
    public class MainMulticast
    {
        public  static void Run()
        {
            MulticastEx eu = new MulticastEx();
            MulticastEx.ArataMesajul ssst = null;
            ssst += new MulticastEx.ArataMesajul(eu.Mesaj1);
            ssst += new MulticastEx.ArataMesajul(eu.Mesaj2);
            ssst += new MulticastEx.ArataMesajul(eu.Mesaj3);
            ssst("Hello, Delegati Multicast");
            ssst -= new MulticastEx.ArataMesajul(eu.Mesaj2);
            ssst("Mesajul 2 a fost sters");

        }

    }
    public class MulticastEx
    {
        public delegate void ArataMesajul(string a);
        public void Mesaj1(string msj)
        {
            Console.WriteLine("Primul mesaj este: {0}", msj);
        }
        public void Mesaj2(string msj)
        {
            Console.WriteLine("Al doilea mesaj este: {0}", msj);
        }
        public void Mesaj3(string msj)
        {
            Console.WriteLine("Al treilea mesaj este: {0}", msj);
        }
       
    }
    
}