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
        private readonly IGroupRepository groupRepository;

        public StudentController(IStudentRepository studentRepository, IGroupRepository groupRepository)
        {
            this.studentRepository = studentRepository;
            this.groupRepository = groupRepository;
        }

        //public IActionResult List()
        //{
        //    StudentsListViewModel studentsListViewModel = new StudentsListViewModel();
        //    studentsListViewModel.Students = studentRepository.GetAll;
        //    studentsListViewModel.CurrentGroup = "All Group";

        //    return View(studentsListViewModel);
        //}

        public IActionResult List(string GroupName)
        {
            IEnumerable<Student> students;
            string CurrentGroup;

            if (string.IsNullOrEmpty(GroupName))
            {
                students = studentRepository.GetAll.OrderBy(s => s.StudentId);
                CurrentGroup = "All student";
            }
            else
            {
                students = studentRepository.GetAll.Where(g => g.Group.GroupName == GroupName)
                    .OrderBy(s => s.StudentId);
                CurrentGroup = groupRepository.GetAll.FirstOrDefault(g => g.GroupName == GroupName)?.GroupName;
            }

            return View(new StudentsListViewModel
            {
                Students = students,
                CurrentGroup = CurrentGroup
            });
        }

        public IActionResult Details(int id)
        {
            var student = studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}