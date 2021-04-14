using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    // Define a delegate  --Step 1
    public delegate void MessageDelegate();
    public delegate String EmailDelegate(string eMail);
    class Email
    {
        public static string GetEmail(string strEmail)
        {
            return "Your Email Id is -> " + strEmail;
        }
        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to CSharp Delegates");
        }
    }
    class TestEmail
    {
        static void Main()
        {
            // Instantiation the Delegate  --Step 2
            MessageDelegate Md = new MessageDelegate(Email.DisplayMessage);
            EmailDelegate Ed = new EmailDelegate(Email.GetEmail);
            // Invoking delegate  --Step 3
            Md.Invoke();
            String stremail = Ed.Invoke("Leninsai3@gmail.com");
            Console.WriteLine(stremail);
            Console.ReadKey();
        }
    }
}
