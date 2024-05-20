using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class RevenueRepo : Repo, IRepo<Revenue, int, bool>, IDisposable
    {
        public void Dispose()
        {
            db.Dispose();
        }
        public bool Create(Revenue obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Revenue> Read()
        {
            throw new NotImplementedException();
        }

        public Revenue Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Revenue obj)
        {
            throw new NotImplementedException();
        }
    }
}
