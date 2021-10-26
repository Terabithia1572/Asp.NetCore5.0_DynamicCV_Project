using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DynamicCV_Project.Controllers
{
    public class EucationController : Controller
    {
        EducationManager educationManager = new EducationManager(new EfEducationRepository());
        public IActionResult Index()
        {
            var values = educationManager.GetList();

            return View(values);
        }
    }
}
