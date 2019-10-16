using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using StudentMVC.ViewModels;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                StudentRankPlatinum = studentRepository.StudentRankPlatinum
            };

            return View(homeViewModel);
        }

    }
}
