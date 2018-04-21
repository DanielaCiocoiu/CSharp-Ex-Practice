using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx
{
    public class TestDelegate
    {
        public  delegate void FirstDelegate();//declar
        public void Fun1()
        {
            Console.WriteLine("I am Function 1");
        }
        public void Fun2()
        {
            Console.WriteLine("I am Fucntion 2");
        }
        public void Fun3()
        {
            Console.WriteLine("I am Function 3");
        }
        public void Execute()
        {
            TestDelegate ex = new TestDelegate();
            TestDelegate.FirstDelegate fd1 = new TestDelegate.FirstDelegate(ex.Fun1);//instantiere
            TestDelegate.FirstDelegate fd2 = new TestDelegate.FirstDelegate(ex.Fun2);
            TestDelegate.FirstDelegate fd3 = new TestDelegate.FirstDelegate(ex.Fun3);
            fd1();
            fd2();
            fd3();
        }

    }
}
