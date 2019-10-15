using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMVC.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Student> GetAll
        {
            get { 
              return dbContext.Students.Include(g => g.Group);
            }
        }

        public Student GetById(int id)
        {
            return dbContext.Students.FirstOrDefault(s => s.StudentId == id);
        }
    }
}
