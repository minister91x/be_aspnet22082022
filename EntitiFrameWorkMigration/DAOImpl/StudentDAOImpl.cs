using EntitiFrameWorkMigration.DAL;
using EntitiFrameWorkMigration.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class StudentDAOImpl : IStudentDAO
    {
        StudentModels studentContext = new StudentModels();
        public List<Student> GetAllStudents()
        {
            var list = new List<Student>();
            try
            {
                list = studentContext.student.ToList();
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
