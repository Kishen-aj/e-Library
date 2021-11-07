using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Library.Core.ViewModels
{
     public class PreOrderBasketSummaryViewModel
     {
        public int BasketCount { get; set; }
        public decimal BasketTotal { get; set; }

        public PreOrderBasketSummaryViewModel()
        {
        }

        public PreOrderBasketSummaryViewModel(int basketCount, decimal basketTotal)
        {
            this.BasketCount = basketCount;
            this.BasketTotal = basketTotal;
        }
     }
}
