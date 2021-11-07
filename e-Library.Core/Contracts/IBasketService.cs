using e_Library.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace e_Library.Core.Contracts
{
    public interface IBasketService
    {
        void AddToBasket(HttpContextBase httpContext, string bookId);
        void AddPreOrderToBasket(HttpContextBase httpContext, string bookId);
        void RemoveFromBasket(HttpContextBase httpContext, string itemId);
        void RemovePreOrderFromBasket(HttpContextBase httpContext, string itemId);
        List<BasketItemViewModel> GetBasketItems(HttpContextBase httpContext);
        List<BasketItemViewModel> GetPreOrderBasketItems(HttpContextBase httpContext);
        BasketSummaryViewModel GetBasketSummary(HttpContextBase httpContext);
        BasketSummaryViewModel GetPreOrderBasketSummary(HttpContextBase httpContext);
        decimal BasketTotal(HttpContextBase httpContext);
        decimal PreOrderBasketTotal(HttpContextBase httpContext);
        void ClearBasket(HttpContextBase httpContext);
    }
}
