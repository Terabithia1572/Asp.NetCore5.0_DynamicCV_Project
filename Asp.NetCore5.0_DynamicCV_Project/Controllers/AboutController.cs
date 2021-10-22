using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DynamicCV_Project.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager();
        public IActionResult Index()
        {
            var values = aboutManager.GetList();
            return View(values);
        }
    }
}
