using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class UserDefinedException : Exception
    {
        public static void validate(int a)
        {
            if (a <= 18)
            {
                throw new InvalidAgeException("Sorry! Age must Be Greater than 18");
            }
            Console.WriteLine("Greater than 18");
        }
    }

    [Serializable]
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class CustomException
    {
        static void Main()
        {
            int age;
            Console.WriteLine("Enter Your Age :");
            age = Convert.ToInt32(Console.ReadLine());
            try {
                UserDefinedException.validate(age);
            }
            catch (InvalidAgeException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
