using Sportsblog.Models;
using Sportsblog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Repositories
{
    public class PostsRepository : IRepository<Posts>
    {
        private SiteContext db;
        public PostsRepository(SiteContext db)
        {
            this.db = db;
        }

        public IEnumerable<Posts> GetAll()
        {
            return db.Posts;
        }

        public Posts GetById(int id)
        {
            return db.Posts.Single(c => c.PostId == id);
        }

        //CRUD
        public void Create(Posts post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public void Delete(Posts post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Edit(Posts post)
        {
            db.Update(post);
            db.SaveChanges();
        }

    }
}

