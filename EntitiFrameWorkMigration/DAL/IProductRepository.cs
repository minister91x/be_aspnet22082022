using EntitiFrameWorkMigration.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiFrameWorkMigration.DAL
{
    public interface IProductRepository
    {
        List<Product> Product_GetAll(); 
        Product GetProductById(int id);
        int Product_Insert(Product product);
        int Product_Update(Product product);
    }
}
