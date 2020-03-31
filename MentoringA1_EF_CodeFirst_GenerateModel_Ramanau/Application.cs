using MentoringA1_EF_CodeFirst_GenerateModel_Ramanau;
using System;
using System.Linq;

namespace MentoringA1_EF_CodeFirst_Ramanau
{
    public class Application
    {
        public void Start()
        {
            using (var context = new NorthwindContext())
            {
                var BeveragesOrders = (from order in context.Orders
                                       join customer in context.Customers on order.CustomerID equals customer.CustomerID
                                       join details in context.Order_Details on order.OrderID equals details.OrderID
                                       join product in context.Products on details.ProductID equals product.ProductID
                                       join category in context.Categories on product.CategoryID equals category.CategoryID
                                       where category.CategoryName == "Beverages"
                                       select new
                                       {
                                           Customer = customer.ContactName,
                                           Product = product.ProductName,
                                           Category = category.CategoryName
                                       }).ToArray();
                Console.ReadKey();
            }
        }
    }
}
