using Microsoft.AspNetCore.Mvc;
using FriendApp.Models;

namespace FriendApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] UserRegistration ur)
        {
            RegisterDB dbop = new RegisterDB();
            dbop.Register(ur);
         
            
                TempData["msg"] = "You have successfully registered";
            
            return View();
        }
    }
     
}
