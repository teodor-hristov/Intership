using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Gold : DiscountCard
    {
        public Gold(double prevMonthTurnover)
            : base(prevMonthTurnover)
        {
            this.DiscountRate = 0.02; // default discount rate for gold card

            if (prevMonthTurnover / 10000 > 0.1)
            {
                this.DiscountRate = 0.1;
            }
            else
            {
                double count = 0;
                double temp = prevMonthTurnover;
                while(temp >= 100)
                {
                    temp -= 100;
                    count++;
                }
                this.DiscountRate = count/100;
            }

        }
    }
}
