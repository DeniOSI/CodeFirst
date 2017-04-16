using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framwork.Model
{
    class PrintDB
    {
        public static void PrintDb(UserContext db)
        {
            var users = db.Users;
            foreach (var item in users)
            {
                Console.WriteLine($"user name: {item.Name}, user family: {item.LastName}, user age: {item.Age}, user sex {item.Sex}");
            }
        }
    }
}
