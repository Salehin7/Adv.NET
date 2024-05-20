using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NoticeRepo : Repo, IRepo<Notice, int, bool>
    {
        public bool Create(Notice obj)
        {
            db.Notices.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var delete = Read(id);
            if (delete != null)
            {
                db.Notices.Remove(delete);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Notice> Read()
        {
            return db.Notices.ToList();
        }

        public Notice Read(int id)
        {
            return db.Notices.Find(id);
        }

        public bool Update(Notice obj)
        {
            var edit = Read(obj.NId);
            if (edit != null)
            {
                db.Entry(edit).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
