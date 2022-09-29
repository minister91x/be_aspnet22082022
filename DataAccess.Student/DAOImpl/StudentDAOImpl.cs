using DataAccess.Student;
using DataAccess.Student.DAL;
using DataAccess.Student.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class StudentDAOImpl : IStudentDAO
    {
       
        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();
            try
            {
                var context = new StudentContext();
                list = context.student.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;


        }

        public int Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
