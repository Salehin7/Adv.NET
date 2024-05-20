using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EventRepo : Repo, IRepo<Event, int, bool>
    {
        public bool Create(Event obj)
        {   
            db.Events.Add(obj);
            if (db.SaveChanges() > 0) return true;

            return false; 
        }

        public bool Delete(int id)
        {
            var delete = Read(id);
            if (delete != null)
            {
                db.Events.Remove(delete);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Event> Read()
        {
            return db.Events.ToList();
        }

        public Event Read(int id)
        {
            return db.Events.Find(id);
        }

        public bool Update(Event obj)
        {
            var edit = Read(obj.EventId);
            if (edit != null)
            {
                db.Entry(edit).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
