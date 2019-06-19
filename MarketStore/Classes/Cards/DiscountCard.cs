using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class DiscountCard : DiscountCardInterface
    {
        private double prevMonthTurnover;
        private double discountRate;
        private double purchaseValue;
        public double PurchaseValue { get; set; }
        public double PrevMonthTurnover { get; protected set; }
        public double DiscountRate { get; protected set; }

        public DiscountCard(double prevMonthTurnover)
        {
            PrevMonthTurnover = prevMonthTurnover;
        }

        public double CalculateDiscount()
        {
            return PurchaseValue * this.DiscountRate;
        }

        public string PrintOwnerInfo()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Purchase value: {PurchaseValue}").AppendLine();
            str.Append($"Discount rate: { this.DiscountRate}").AppendLine();
            str.Append($"Discount: {this.CalculateDiscount()}").AppendLine();
            str.Append($"Total: {PurchaseValue-CalculateDiscount()}").AppendLine();
            return str.ToString();
        }
    }
}
