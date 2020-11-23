﻿using System;
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
            Company microsoft = new Company()
            {
                Name = "Microsoft",
                Employees = 5000000
            };
            string result = $"Name: {microsoft.Name}, Employees: {microsoft.Employees}";
            return result;
        }
    }
}
