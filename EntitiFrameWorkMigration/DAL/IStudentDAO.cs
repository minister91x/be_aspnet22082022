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

        int StudentUpdate(int StudentId);

        int Student_Delete(int StudentId);

        Student Student_GetByID(int StudentId);

    }
}
