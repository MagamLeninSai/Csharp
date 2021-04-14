using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
	class DataStore1<T>
	{
		private T[] _data = new T[10];

		public void AddOrUpdate(int index, T item)
		{
			if (index >= 0 && index < 10)
				_data[index] = item;
		}

		public T GetData(int index)
		{
			if (index >= 0 && index < 10)
				return _data[index];
			else
				return default(T);
		}
	}
	public class GenericMethodDemo1
	{
		public static void Main()
		{
			DataStore1<string> cities = new DataStore1<string>();
			cities.AddOrUpdate(0, "Mumbai");
			cities.AddOrUpdate(1, "Chicago");
			cities.AddOrUpdate(2, "London");

			Console.WriteLine(cities.GetData(1));

			DataStore1<int> empIds = new DataStore1<int>();
			empIds.AddOrUpdate(0, 50);
			empIds.AddOrUpdate(1, 65);
			empIds.AddOrUpdate(2, 89);

			Console.WriteLine(empIds.GetData(0));
			Console.ReadKey();
		}
	}
}
