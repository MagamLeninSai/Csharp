using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class HashtableDemo2
    {
		public static void Main()
		{
			//creating a Hashtable using collection-initializer syntax
			var cities = new Hashtable(){
			{"UK", "London, Manchester, Birmingham"},
			{"USA", "Chicago, New York, Washington"},
			{"India", "Mumbai, New Delhi, Pune"}
		     
			};

			string citiesOfUK = (string)cities["UK"]; //cast to string
			string citiesOfUSA = (string)cities["USA"]; //cast to string

			Console.WriteLine(citiesOfUK);
			Console.WriteLine(citiesOfUSA);

			cities["UK"] = "Liverpool, Bristol"; // update value of UK key
			cities["USA"] = "Los Angeles, Boston"; // update value of USA key

			if (!cities.ContainsKey("France"))
			{
				cities["France"] = "Paris";
			}

			Console.WriteLine("---After updating values---");

			foreach (DictionaryEntry de in cities)
				Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);
			Console.ReadKey();
		}
	}
}
