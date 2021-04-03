using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("hello world");
            return View();
            
        }
    }
}
