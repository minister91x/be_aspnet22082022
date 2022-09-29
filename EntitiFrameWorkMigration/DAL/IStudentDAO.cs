using EntitiFrameWorkMigration.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAL
{
    public interface IStudentDAO
    {
        List<Student> GetAllStudents();
        int Save(Student student);
    }
}
