using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public string History { get; set; }
        public  bool Sex { get; set; }
        public bool IsPlatinum { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
