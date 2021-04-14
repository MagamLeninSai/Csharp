using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo3
{
    public partial class Technician
    {
        partial void setData(); //private method(by Default), no implemention(like abstract), always in partial class, can implement in same partial class or in diff partial class
    }
    public partial class Technician
    {
        public void setSalary()
        {
            setData(); // calling partial method we can call this method if we want partial method
        }
        partial void setData() // implementing partial method
        {
            Console.WriteLine("This is partial Method");
        }
    }
    class PartialMethodDemo
    {
        public static void Main()
        {
            Technician t = new Technician();
            t.setSalary();
            Console.ReadKey();
        }
    }
}
