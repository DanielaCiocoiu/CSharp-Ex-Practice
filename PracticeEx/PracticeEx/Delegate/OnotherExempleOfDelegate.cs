using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEx.Delegate
{
    public delegate void HelloFucntionDelegate(string Message);

    public class OnotherExempleOfDelegate
    {
        public static void HelloMessage(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        public static void ExecuteDel()
        {
            HelloFucntionDelegate del = new HelloFucntionDelegate(HelloMessage);
            del("Hello from Delegate");
        }
    }

    //---------------------------------------another exemple--------------------------
    delegate bool IsPromotable(Employees empl);
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

       // public static void PromoteEmployee(List<Employees> employeeList, IsPromotable IsEligibleToPromote)
        //{
        //    foreach (Employees employees in employeeList)
        //    {
        //        if (IsEligibleToPromote(employees))
        //        {
        //            Console.WriteLine(employees.Name + " promoted");
        //        }
        //    }
        //}
    }
    public class ExecuteEmployee
    {
        public static void ExecuteEmp()
        {
            List<Employees> empList = new List<Employees>();
            empList.Add(new Employees() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employees() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4 });
            empList.Add(new Employees() { ID = 101, Name = "Nuky", Salary = 2000, Experience = 6 });
            empList.Add(new Employees() { ID = 101, Name = "Lili", Salary = 3000, Experience = 3 });



           // Employees.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }
       
    }
}
