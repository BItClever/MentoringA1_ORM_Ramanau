using MentoringA1_EF_DBfirst_Ramanau.Interfaces;
using MentoringA1_EF_DBfirst_Ramanau.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MentoringA1_EF_DBfirst_Ramanau
{
    public class UnitOfWork : IDisposable
    {
        private readonly IOrderRepository orderRepository;
        private bool disposed = false;

        public UnitOfWork(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public bool AddOrder(Order order)
        {
            return orderRepository.Create(order);
        }

        public bool ChangeOrderDate(DateTime orderDate, int orderID)
        {
            return orderRepository.ChangeOrderDate(orderDate, orderID);
        }

        public bool ChangeShippedDate(DateTime shippedDate, int orderID)
        {
            return orderRepository.ChangeShippedDate(shippedDate, orderID);
        }

        public Order GetOrderById(int OrderID)
        {
            return orderRepository.Get(OrderID);
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAll().ToList();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    
                }
                disposed = true;
            }
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}


