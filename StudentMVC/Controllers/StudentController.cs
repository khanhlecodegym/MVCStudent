using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using StudentMVC.ViewModels;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public IActionResult List()
        {
            StudentsListViewModel studentsListViewModel = new StudentsListViewModel();
            studentsListViewModel.Students = studentRepository.GetAll;
            studentsListViewModel.CurrentGroup = "All Group";
           
            return View(studentsListViewModel);
        }
    }
}