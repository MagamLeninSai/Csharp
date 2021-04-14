using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class FuncDemo1
    {

            static void Main(string[] args)
            {
                Func<int, int, int> add1 = new Func<int, int, int>(MethodCollections.Addition);
                Func<int, int, string> add2 = new Func<int, int, string>(MethodCollections.DisplayAddition);
                Func<string, string, string> completeName = new Func<string, string, string>(MethodCollections.SHowCompleteName);
                Func<int> random = new Func<int>(MethodCollections.ShowNumber);


                Console.WriteLine("**************** Func<> Delegate Methods *****************\n");
                int addition = add1(2, 5);  //Parameter: 2 , Returns: int  
                string addition2 = add2(5, 8);  //Parameter: 2 , Returns: string  
                string name = completeName("Lenin", "Sai");    //Parameter:2 , Returns: string  
                int randomNumbers = random();   ////Parameter: 0 , Returns: int  

                Console.WriteLine("Addition: {0}", addition);
                Console.WriteLine(addition2);
                Console.WriteLine(name);
                Console.WriteLine("Random Number is: {0}", randomNumbers);

                Console.ReadLine();

            }
    }

}

