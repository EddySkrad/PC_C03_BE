using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            User user01 = new User("frc", "1991");
            User user02 = new User("mcr", "1992");
            User user03 = new User();
            
            user01.Validate(user01.UserName, user01.UserPassword);
            user02.Validate(user02.UserName, user02.UserPassword);
            user03.PedirUser();
            user03.Validate(user03.UserName, user03.UserPassword);

            Console.ReadKey();

        }
    }
}
