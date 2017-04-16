using Entity_Framwork.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity_Framwork
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            User user1 = new User { Id = 1, Name = "Denis", LastName = "Osipenko", Age = 33, Sex = 'M', Email = "user@mail.ru" };
            User user2 = new User {Id =2,  Name = "Tatyana", LastName = "Osipenko", Age = 32, Sex = 'W', Email = "user1@mail.ru" };
            using (UserContext db = new UserContext())
            {
                Default df = new Default();
                df.InitializeDatabase(db);
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                PrintDB.PrintDb(db);


            }
        }
    }
}
