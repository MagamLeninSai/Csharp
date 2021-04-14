using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    [Serializable()]
    class UserDetails
    {
        int userId;
        string userName;
        [NonSerialized()]
        String location;  //like transiant in java

        public UserDetails(int userId, string userName, string location)
        {
            this.userId = userId;
            this.userName = userName;
            this.location = location;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Location { get => location; set => location = value; }

        public void GetDetails()
        {
            Console.WriteLine("User Id       : "+ UserId);
            Console.WriteLine("User Name     : "+ UserName);
            Console.WriteLine("User Location : "+ Location);
        }
    }
}
