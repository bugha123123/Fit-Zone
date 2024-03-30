using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Instagram_Clone.Controllers
{
    public class HomeController : Controller
    {

      

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }





    }
}
