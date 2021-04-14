using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    abstract class ClsEmployee
    {
        protected int EmpId;
        protected String EName;

        protected ClsEmployee()
        {
            Console.WriteLine("Abstract class Constructor");
        }
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee Id is :"+this.EmpId);
            Console.WriteLine("Employee Name is :" + this.EName);
        }
        public abstract void GetEmpData();

    }
    class Manager : ClsEmployee
    {
        double bonus, CA;
        public override void GetEmpData()
        {
            Console.WriteLine("ENTER MANAGER DETAILS");
            Console.WriteLine("Enter the Manager Id: ");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Manager name: ");
            EName = Console.ReadLine();
            Console.WriteLine("Enter the manager Bonus: ");
            bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Manager CA: ");
            CA = double.Parse(Console.ReadLine());
        }
        public override void DisplayEmpData()
        {
            Console.WriteLine("manager id is: " + EmpId);
            Console.WriteLine("manager name is: " + EName);
            Console.WriteLine("manager bonus is: " + bonus);
            Console.WriteLine("Manager CA is: " + CA);
        }
    }
    class OverrideEmployee
    {
        static void Main()
        {
            Manager m = new Manager();
            m.GetEmpData();
            m.DisplayEmpData();
            Console.ReadKey();
        }
    }
}
