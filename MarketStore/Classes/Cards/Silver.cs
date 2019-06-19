using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Silver : DiscountCard
    {
        public Silver(double prevMonthTurnover)
            : base(prevMonthTurnover)
        {
            this.DiscountRate = 0.02; // default discount rate for silver card
            if (prevMonthTurnover > 300)
            {
                this.DiscountRate = 0.035;
            }
        }
    }
}
