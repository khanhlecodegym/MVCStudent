﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentMVC.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}