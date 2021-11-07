using e_Library.Core.Contracts;
using e_Library.Core.Models;
using e_Library.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Library.Services
{
    public class PreOrderService : IPreOrderService
    {
        IRepository<PreOrder> orderContext;
        public PreOrderService(IRepository<PreOrder> OrderContext)
        {
            this.orderContext = OrderContext;
        }

        public void CreatePreOrder(PreOrder baseOrder, List<BasketItemViewModel> basketItems)
        {
            foreach (var item in basketItems)
            {
                baseOrder.OrderItems.Add(new PreOrderItem()
                {
                    BookId = item.Id,
                    Image = item.Image,
                    Price = item.Price,
                    BookName = item.BookName,
                    Quantity = item.Quantity
                });
            }

            orderContext.Insert(baseOrder);
            orderContext.Commit();
        }

        public List<PreOrder> GetPreOrderList() //Returns list of orders
        {
            return orderContext.Collection().ToList();
        }

        public PreOrder GetPreOrder(string Id) //Returns an individual order
        {
            return orderContext.Find(Id);
        }

        public void UpdatePreOrder(PreOrder updatedOrder) //Updates order (Order Status)
        {
            orderContext.Update(updatedOrder);
            orderContext.Commit();
        }
    }
}
