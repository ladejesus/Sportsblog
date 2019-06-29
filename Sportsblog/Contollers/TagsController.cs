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

        //Takes user to the main landing page named AllTags, displays Tag info.
        public ViewResult AllTags()
        {
            var model = tagsRepo.GetAll();
            return View(model);
        }

        //Takes user to the Single Tag page which displays the Posts within the selected Tag.
        public ActionResult SingleTag(int id)
        {
            var model = tagsRepo.GetById(id);
            return View(model);
        }

    }
}