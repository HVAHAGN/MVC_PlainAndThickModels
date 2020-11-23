using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.PlainModels.Models;

namespace _001.PlainModels.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Company microsoft = new Company("Microsoft", 5000000);
            return microsoft.GetInfo();
        }
    }
}
