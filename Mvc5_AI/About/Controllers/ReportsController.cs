using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace About.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        [Authorize]
        public IActionResult UserReport()
        {
            return View();
        }

        [Authorize(Roles = "member")]
        public IActionResult MemberReport()
        {
            return View();
        }
    }
}
