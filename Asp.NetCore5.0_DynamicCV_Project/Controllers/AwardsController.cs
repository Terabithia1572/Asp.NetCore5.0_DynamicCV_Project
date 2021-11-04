using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DynamicCV_Project.Controllers
{
    [AllowAnonymous]
    public class AwardsController : Controller
    {
        AwardManager awardsManager = new AwardManager(new EfAwardRepository());
        public IActionResult Index()
        {
            var values = awardsManager.GetList();
            return View(values);
        }
    }
}
