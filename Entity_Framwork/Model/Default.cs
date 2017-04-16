using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity_Framwork.Model
{
    class Default: DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new User { Id = 3, Name = "Vlada", LastName = "Osipenko", Age = 11, Sex = 'W', Email = "user1@mail.ru" });
            db.Users.Add(new User{  Id = 4, Name = "Sasha", LastName = "Osipenko", Age = 4, Sex = 'W', Email = "user1@mail.ru" });
            base.Seed(db);
        }
    }
}
