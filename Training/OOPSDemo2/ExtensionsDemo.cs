using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
   public static  class ExtensionsDemo
    {
        public static bool IsGreaterThan(this int i,int value)  //Extension method
        {
            return i > value;
        }
    }
}
