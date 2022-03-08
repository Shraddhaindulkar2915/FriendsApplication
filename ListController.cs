using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using FriendApp.Models;
using Newtonsoft.Json;

namespace FriendApp.Controllers
{
    public class ListController : Controller
    {
        public ActionResult Index()
        {
            Profiledb Pfdb=new Profiledb();

            return View(Pfdb.getProfile());   
        }
    }
}
