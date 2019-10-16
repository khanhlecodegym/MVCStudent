using StudentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Student> StudentRankPlatinum { get; set; }
    }
}
