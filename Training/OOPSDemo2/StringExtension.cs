using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo2
{
    public static class StringExtension
    {
        public static int GetWordCount(this String inputstring)
        {
            if (!String.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Length;
                //or
                //return strArray.Count();
            }
            else
            {
                return 0;
            }
          
        }
    }
}
