using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    class Branch
    {
        int BranchCode;
        string BranchName, BranchAddress;
        public Branch() {
            Console.WriteLine("Branch COnstructor");
        }
        public void GetBranchData()
        {
            Console.WriteLine("ENTER BRANCH DETAILS:");
            Console.WriteLine("ENTER BRANCH CODE");
            BranchCode = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER BRANCH NAME");
            BranchName = Console.ReadLine();
            Console.WriteLine("ENTER BRANCH ADDRESS");
            BranchAddress = Console.ReadLine();
        }
        public void DisplayBranchData()
        {
            Console.WriteLine("BRANCH CODE IS : " + BranchCode);
            Console.WriteLine("BRANCH NAME IS : " + BranchName);
            Console.WriteLine("BRANCH ADDRESS IS : " + BranchAddress);
        }
    }
}
