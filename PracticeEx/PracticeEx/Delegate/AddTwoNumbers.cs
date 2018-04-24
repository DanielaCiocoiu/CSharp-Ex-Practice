using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Delegate
{
   
    public class AddTwoNumbers    //Clasa Publisher
    {
        public delegate void dg_NumarImpar();//declar delegat
        public event dg_NumarImpar ev_NumarImpar;//declar eveniment
        public void Add()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result.ToString());
            if ((result % 2 != 0) && (ev_NumarImpar != null))//verific daca este nr impar, apoi declanseaza ev
            {
                ev_NumarImpar(); //declansez Event
            }
        }
    }
    public class Subscriber
    {
        public static void Execute()//clasa subscriber
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.ev_NumarImpar += new AddTwoNumbers.dg_NumarImpar(EventMessage);//leg evenimentul de delegat
            a.Add();
            Console.ReadLine(); 
        }
        public static void EventMessage()  //deleg cheama aceasta metoda cand evenimentul este declansat  
        {
            Console.WriteLine("********Event Executed : Acesta este un numar impar**********");
        }
      
    }
}
