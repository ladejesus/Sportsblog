using Sportsblog.Models;
using Sportsblog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Repositories
{
    public class SportsRepository : IRepository<Sports>
    {
        private SiteContext db;

        public SportsRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Sports> GetAll()
        {
            return db.Sports;
        }

        public Sports GetById(int id)
        {
            return db.Sports.Single(c => c.SportId == id);
        }


        //unused
        public void Create(Sports obj)
       {
           throw new NotImplementedException();
        }

        public void Delete(Sports obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Sports obj)
        {
            throw new NotImplementedException();
        }
    }
}
