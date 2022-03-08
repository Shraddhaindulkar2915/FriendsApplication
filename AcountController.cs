using Microsoft.AspNetCore.Mvc;
using FriendApp.Models;

namespace FriendApp.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] LoginViewModel  lv)
        {
            Db dbop=new Db();
            int res = dbop.LoginCheck(lv);
            if (res == 1)
            {
                TempData["msg"] = "You are welcome to Admin Section";
            }
            else
            {
                TempData["msg"] = "Admin id or Password is wrong.!";
            }
            return View();
        }
          

    }
}
