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
    public class AdminAwardController : Controller
    {
        AwardManager awardManager = new AwardManager(new EfAwardRepository());
        public IActionResult Index()
        {
            var values = awardManager.GetList();
            return View(values);
        }
        [HttpGet]

        public IActionResult AwardUpdate(int id)
        {
            var values = awardManager.GetById(id);
            return View();
        }
        [HttpPost]
        public IActionResult AwardUpdate(Award t)
        {
            awardManager.Update(t);
            return RedirectToAction("Index", "Award");
        }
        [HttpPost]
        public IActionResult AddAward(Award t)
        {
              awardManager.Add(t);
                return RedirectToAction("Index", "Award");


        }
    }
}
