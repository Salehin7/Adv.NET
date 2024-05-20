using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ScheduleRepo : Repo, IRepo<Schedule, int, bool>
    {
        public bool Create(Schedule obj)
        {
            db.Schedules.Add(obj);
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            var delete = Read(id);
            db.Schedules.Remove(delete);
            return (db.SaveChanges() > 0);
        }

        public List<Schedule> Read()
        {
            return db.Schedules.ToList();
        }

        public Schedule Read(int id)
        {
            return db.Schedules.Find(id);
        }

        public bool Update(Schedule obj)
        {
            var edit = Read(obj.Id);
            db.Entry(edit).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return true;
            return false;
        }
    }
}
