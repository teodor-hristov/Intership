using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //test input for turnover for the previous month and value of purchase to calculate the discount
            double prevMonthTurnonver = 600;
            double valueOfPurchase = 850;

            // initialize classes
            
            DiscountCard card = new DiscountCard(prevMonthTurnonver);
            Bronze bronze = new Bronze(prevMonthTurnonver);
            bronze.PurchaseValue += valueOfPurchase;
            Silver silver = new Silver(prevMonthTurnonver);
            silver.PurchaseValue += valueOfPurchase;
            Gold gold = new Gold(prevMonthTurnonver);
            gold.PurchaseValue += valueOfPurchase;
            
            //use whatever you want with implemented paydesk methods
            PayDesk paydesk = new PayDesk(silver);
            paydesk.Discount();
            paydesk.DiscountRate();

            //Console.WriteLine(bronze.PrintOwnerInfo());
            //Console.WriteLine(silver.PrintOwnerInfo());
            //Console.WriteLine(gold.PrintOwnerInfo());


        }
    }
}
