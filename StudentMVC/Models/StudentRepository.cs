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
                //return dbContext.Students.OrderByDescending(s => s.StudentId).Take(3).Include(g => g.Group);
                return dbContext.Students.Include(g => g.Group);
            }
        }

        public IEnumerable<Student> StudentRankPlatinum => dbContext.Students.Include(g => g.Group).Where(s => s.IsPlatinum);

        public Student GetById(int id)
        {
            return dbContext.Students.Include(g => g.Group).FirstOrDefault(s => s.StudentId == id);
        }
    }
}
