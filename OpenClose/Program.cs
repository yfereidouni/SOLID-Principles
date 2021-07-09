using System;

namespace OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            Order orderRegular = new Order(new RegularMembership());
            orderRegular.TotalValue = 1000;

            Order orderSilver = new Order(new SilverMembership());
            orderSilver.TotalValue = 1000;

            Order orderPlatnium = new Order(new PlatinumMembership());
            orderPlatnium.TotalValue = 1000;

            Console.WriteLine("Price: " + orderRegular.GetFinalValue());
            Console.WriteLine("Price: " + orderSilver.GetFinalValue());
            Console.WriteLine("Price: " + orderPlatnium.GetFinalValue());
        }
    }
}
