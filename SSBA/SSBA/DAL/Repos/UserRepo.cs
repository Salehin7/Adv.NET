using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, string, bool>
    {
        public bool Create(User obj)
        {
            db.Users.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(string id)
        {
            var delete = Read(id);
            if (delete != null)
            {
                db.Users.Remove(delete);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(string id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User obj)
        {
            var edit = Read(obj.UId);
            if (edit != null)
            {
                db.Entry(edit).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
