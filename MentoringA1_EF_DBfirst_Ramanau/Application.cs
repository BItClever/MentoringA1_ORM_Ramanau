using MentoringA1_EF_DBfirst_Ramanau.Interfaces;
using System;

namespace MentoringA1_EF_DBfirst_Ramanau
{
    public class Application
    {
        public void Start()
        {
            var serviceLocator = new ServiceLocator();
            using (var unitOfWork = new UnitOfWork(
                serviceLocator.Resolve<IOrderRepository>()))
            {
                var orders = unitOfWork.GetAllOrders();
                var order = unitOfWork.GetOrderById(10248);
            }
               
            Console.ReadKey();
        }
    }
}