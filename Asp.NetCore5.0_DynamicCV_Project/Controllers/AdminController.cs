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
    public class AdminController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult AboutIndex()
        {
            var values = aboutManager.GetList();
            return View();
        }
        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = aboutManager.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult AboutUpdate(About t)
        {

            aboutManager.Update(t);
            return RedirectToAction("Index", "About");

        }
    }
}
