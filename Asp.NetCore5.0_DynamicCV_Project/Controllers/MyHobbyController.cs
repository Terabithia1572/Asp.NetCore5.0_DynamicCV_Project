using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DynamicCV_Project.Controllers
{
    public class MyHobbyController : Controller
    {
        MyHobbyManager myHobbyManager = new MyHobbyManager(new EfMyHobbyRepository());
        public IActionResult Index()
        {
            var values = myHobbyManager.GetList();
            return View(values);
        }
    }
}
