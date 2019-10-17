using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll { get; }
        IEnumerable<Student> StudentRankPlatinum { get; }
        void Add(Student student);
        void Commit();
        Student GetById(int id);
    }
}
