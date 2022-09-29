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
            var result = 0;
            try
            {
                studentContext.student.Add(student);
                result = studentContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public int StudentUpdate(int StudentId)
        {
            throw new NotImplementedException();
        }

        public int Student_Delete(int StudentId)
        {
            throw new NotImplementedException();
        }

        public Student Student_GetByID(int StudentId)
        {
            throw new NotImplementedException();
        }
    }
}
