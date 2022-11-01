using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiFrameWorkMigration.DAL;
using EntitiFrameWorkMigration.DAO;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class CustomerReporsitory : ICustomerRepository
    {
        StudentModels _entities = new StudentModels();
        public void Add(Customer customer)
        {
            _entities.customer.Add(customer);
        }

        public void SaveChange()
        {
            _entities.SaveChanges();
        }
    }
}
