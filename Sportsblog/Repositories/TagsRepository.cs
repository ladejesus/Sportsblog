using Sportsblog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Repositories
{
    public class TagsRepository : IRepository<Tags>
    {
        private SiteContext db;

        public TagsRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Tags> GetAll()
        {
            return db.Tags;
        }

        public Tags GetById(int id)
        {
            return db.Tags.Single(c => c.TagId == id);
        }


        //unused
        public void Create(Tags obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tags obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tags obj)
        {
            throw new NotImplementedException();
        }
    }
}
