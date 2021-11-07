using e_Library.Core.Models;
using e_Library.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Library.Core.Contracts
{
    public interface IPreOrderService
    {
        void CreateOrder(PreOrder baseOrder, List<BasketItemViewModel> basketItems);
        List<PreOrder> GetOrderList();
        PreOrder GetOrder(string Id);
        void UpdateOrder(PreOrder updatedOrder);

    }
}
