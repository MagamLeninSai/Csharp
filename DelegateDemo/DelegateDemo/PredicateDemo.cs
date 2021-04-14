using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
	public class PredicateDemo
	{
		public static void Main()
		{
			Predicate<string> isUpper = s => s.Equals(s.ToUpper());
			bool result = isUpper("hello world!!");

			Console.Write(result);
			Console.ReadKey();
		}
	}
}
