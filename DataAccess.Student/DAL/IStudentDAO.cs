using DataAccess.Student.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Student.DAL
{
    public interface IStudentDAO
    {
        List<DataAccess.Student.DAO.Student> GetAllStudents();
        int Save(DataAccess.Student.DAO.Student student);
    }
}
