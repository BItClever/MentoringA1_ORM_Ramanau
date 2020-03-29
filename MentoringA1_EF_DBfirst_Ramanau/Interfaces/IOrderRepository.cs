using MentoringA1_EF_DBfirst_Ramanau.Models;
using System;
using System.Collections.Generic;

namespace MentoringA1_EF_DBfirst_Ramanau.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order Get(int id);
        bool Create(Order order);
        bool ChangeOrderDate(DateTime newOrderDate, int orderID);
        bool ChangeShippedDate(DateTime newShippedDate, int orderID);
    }
}
