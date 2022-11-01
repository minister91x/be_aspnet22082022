using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiFrameWorkMigration.DAOImpl;

namespace EntitiFrameWorkMigration.UnitWork
{
    public class UnitWork
    {
        private CustomerReporsitory _customerReporsitory;
        private OrderRepository _orderRepository;
        private StudentRepository _studentRepository;
        private StudentModels _entities;

        public UnitWork(StudentModels Entities)
        {
            _entities = Entities;
        }

        //public UnitWork(CustomerReporsitory customerReporsitory, OrderRepository orderRepository)
        //{
        //    _customerReporsitory = customerReporsitory;
        //    _orderRepository = orderRepository;
        //}
        public CustomerReporsitory CusRepo
        {
            get
            {
                if (_customerReporsitory == null)
                {
                    _customerReporsitory = new CustomerReporsitory();
                }
                return _customerReporsitory;
            }
        }

        public OrderRepository orderRepo
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository();
                }
                return _orderRepository;
            }
        }

        public StudentRepository studentRepo
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository();
                }
                return _studentRepository;
            }
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}
