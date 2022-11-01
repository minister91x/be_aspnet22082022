using EntitiFrameWorkMigration.DAL;
using EntitiFrameWorkMigration.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class StudentRepository : IStudentDAO
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
            var result = 0;
            try
            {
                var student_database = studentContext.student.ToList().FindAll(s => s.Id == StudentId).FirstOrDefault();
               
                if (student_database == null && student_database.Id <= 0)
                {
                    result = -1;
                    return result;
                }

                studentContext.student.Remove(student_database);
                result = studentContext.SaveChanges();

            }
            catch (Exception ex)
            {
                result = -969;
            }
            return result;
        }

        public Student Student_GetByID(int StudentId)
        {
            throw new NotImplementedException();
        }
    }
}
