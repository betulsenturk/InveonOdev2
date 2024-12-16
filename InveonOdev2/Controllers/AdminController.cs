using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InveonOdev2.Controllers
{
    [Authorize(Roles = "Admin")] 
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
