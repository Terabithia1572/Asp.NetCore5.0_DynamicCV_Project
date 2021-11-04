using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DynamicCV_Project.Controllers
{
    public class AdminExperienceController : Controller
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceRepository());
        public IActionResult Index()
        {
            var value = em.GetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult ExperienceUpdate(int id)
        {
            var value = em.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult ExperienceUpdate(Experience t)
        {
            em.Update(t);
            return RedirectToAction("Index", "Experience");
        }

        [HttpGet]
        public IActionResult AddExperience()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience t)
        {
            em.Add(t);
            return RedirectToAction("Index", "Experience");
        }

    }
}
