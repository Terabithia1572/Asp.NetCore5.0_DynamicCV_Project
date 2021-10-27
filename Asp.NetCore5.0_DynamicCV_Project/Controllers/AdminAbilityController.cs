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
    public class AdminAbilityController : Controller
    {
        AbilityManager abilityManager = new AbilityManager(new EfAbilityRepository());
        public IActionResult Index()
        {
            var values = abilityManager.GetList();
            return View(values);
        }
        [HttpGet]
      public IActionResult UpdateAbility(int id)
        {
            var values = abilityManager.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbility(Ability t)
        {
            abilityManager.Update(t);
            return RedirectToAction("Index", "Ability");
        }
        [HttpGet]

        public IActionResult AddAbility()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAbility(Ability t)
        {
            abilityManager.Add(t);
            return RedirectToAction("Index", "Ability");
        }
    }
}
