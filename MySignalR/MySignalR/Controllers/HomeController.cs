using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Text;
//using MySignalR.Models;

namespace MySignalR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
