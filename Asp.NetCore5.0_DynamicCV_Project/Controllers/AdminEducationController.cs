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
    public class AdminEducationController : Controller
    {
        EducationManager educationManager = new EducationManager(new EfEducationRepository());
        public IActionResult Index()
        {
            var value = educationManager.GetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult EducationUpdate(int id)
        {
            var value = educationManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EducationUpdate(Education t)
        {
            educationManager.Update(t);
            return RedirectToAction("Index", "Education");
        }

        [HttpGet]
        public IActionResult AddEducation()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddEducation(Education t)
        {
            educationManager.Add(t);
            return RedirectToAction("Index", "Education");
        }
    }
}
