using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiFrameWorkMigration.DAO;
namespace EntitiFrameWorkMigration.DAL
{
    public interface IOrderRepository
    {
        void Add(Order order);
    }
}
