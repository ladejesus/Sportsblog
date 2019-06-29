using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sportsblog.Models;
using Sportsblog.Repository;

namespace Sportsblog.Contollers
{
    public class SportsController : Controller
    {
        IRepository<Sports> sportsRepo;

        public SportsController(IRepository<Sports> sportsRepo)
        {
            this.sportsRepo = sportsRepo;
        }

        //Takes user to the main landing page named AllSports, displays sports.
        public ViewResult Index()
        {
            var model = sportsRepo.GetAll();
            return View(model);
        }

        //Takes user to the Single Sport page which displays the posts within the selected sport.
        public ActionResult SingleSport(int id)
        {
            var model = sportsRepo.GetById(id);
            return View(model);
        }

    }
}
