using Microsoft.AspNetCore.Mvc.Rendering;
using StudentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public SelectList Groups { get; set; }
    }
}
