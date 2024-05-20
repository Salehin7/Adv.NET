using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SponsorRepo : Repo, IRepo<Sponsor, int, bool>
    {
        public bool Create(Sponsor obj)
        {
            db.Sponsors.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var delete = Read(id);
            if (delete != null)
            {
                db.Sponsors.Remove(delete);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Sponsor> Read()
        {
            return db.Sponsors.ToList();
        }

        public Sponsor Read(int id)
        {
            return db.Sponsors.Find(id);
        }

        public bool Update(Sponsor obj)
        {
            var edit = Read(obj.SponsorId);
            if (edit != null)
            {
                db.Entry(edit).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
