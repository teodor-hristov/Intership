using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Bronze : DiscountCard
    {
        public Bronze(double prevMonthTurnover) 
            : base(prevMonthTurnover)
        {
            if(prevMonthTurnover < 100)
            {
                this.DiscountRate = 0;
            }
            else if(prevMonthTurnover < 300 && prevMonthTurnover >= 100)
            {
                this.DiscountRate = 0.01;
            }
            else
            {
                this.DiscountRate = 0.025;
            }
        }
    }
}
