using EntitiFrameWorkMigration.DAL;
using EntitiFrameWorkMigration.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class ProductRepository : IProductRepository
    {
        StudentModels studentContext = new StudentModels();
        public Product GetProductById(int id)
        {
            return studentContext.product.Where(s => s.ProductId == id).FirstOrDefault();
        }

        public List<Product> Product_GetAll()
        {
            return studentContext.product.ToList();
        }

        public int Product_Insert(Product product)
        {
            studentContext.product.Add(product);
            return studentContext.SaveChanges();
        }

        public int Product_Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
