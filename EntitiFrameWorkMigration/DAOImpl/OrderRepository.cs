using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiFrameWorkMigration.DAL;
using EntitiFrameWorkMigration.DAO;

namespace EntitiFrameWorkMigration.DAOImpl
{
    public class OrderRepository : IOrderRepository
    {
        StudentModels _entities = new StudentModels();
        public void Add(Order order)
        {
            _entities.order.Add(order);
        }

        public void SaveChange()
        {
            _entities.SaveChanges();
        }
    }
}
