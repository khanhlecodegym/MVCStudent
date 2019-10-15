using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll { get; }
        Student GetById(int id);
    }
}
