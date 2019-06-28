using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sportsblog.Models;
using Sportsblog.Repository;

namespace Sportsblog.Contollers
{
    public class TagsController : Controller
    {
        IRepository<Tags> tagsRepo;

        public TagsController(IRepository<Tags> tagsRepo)
        {
            this.tagsRepo = tagsRepo;
        }

        //Takes user to the main landing page named AllGenres, displays genres.
        public ViewResult AllGenres()
        {
            var model = tagsRepo.GetAll();
            return View(model);
        }

        //Takes user to the Single Genre page which displays the movies within the selected genre.
        public ActionResult SingleGenre(int id)
        {
            var model = tagsRepo.GetById(id);
            return View(model);
        }

    }
}