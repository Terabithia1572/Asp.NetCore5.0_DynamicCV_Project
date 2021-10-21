using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DynamicCV_Project.Controllers
{
    public class AbilityController : Controller
    {
        AbilityManager am = new AbilityManager(new EfAbilityRepository());
        public IActionResult Index()
        {
            var values = am.GetList();
            return View(values);
        }
    }
}
