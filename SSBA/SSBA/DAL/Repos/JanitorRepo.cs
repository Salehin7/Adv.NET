using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class JanitorRepo : Repo, IRepo<Janitor, int, bool>
    {
        public bool Create(Janitor obj)
        {
            db.Janitors.Add(obj);
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            var delete = Read(id);
            if (delete != null)
            {
                db.Janitors.Remove(delete);
                return db.SaveChanges() > 0;
            }
            return false;

        }

        public List<Janitor> Read()
        {
            return db.Janitors.ToList();
        }

        public Janitor Read(int id)
        {
            return db.Janitors.Find(id);
        }

        public bool Update(Janitor obj)
        {
            var edit = Read(obj.JId);
            db.Entry(edit).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return true;
            return false;
        }
    }
}
