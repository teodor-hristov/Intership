using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class PayDesk : PayDeskInterface
    {
        private DiscountCard card;

        public PayDesk(DiscountCard card)
        {
            this.card = card;
        }
        public void Discount()
        {
            Console.WriteLine(card.CalculateDiscount());
        }

        public void DiscountRate()
        {
            Console.WriteLine(card.DiscountRate);
        }

        public void Total()
        {
            Console.WriteLine(card.PurchaseValue - card.CalculateDiscount());
        }

   
    }
}
