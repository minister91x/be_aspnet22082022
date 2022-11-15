using EntitiFrameWorkMigration.DAL;
using EntitiFrameWorkMigration.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class CategoryRepository : ICategory
    {
        StudentModels studentContext = new StudentModels();
        public List<Category> Category_GetList()
        {
           return studentContext.category.ToList();
        }
    }
}
