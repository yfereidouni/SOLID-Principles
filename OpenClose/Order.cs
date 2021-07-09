using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public abstract class CalculateFinalPrice
    {
        public abstract int Calculate(int price);
    }

    public class RegularMembership : CalculateFinalPrice
    {
        public override int Calculate(int price)
        {
            return price;
        }
    }

    public class SilverMembership : CalculateFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - ((int)(price * 0.1));
        }
    }

    public class PlatinumMembership : CalculateFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - ((int)(price * 0.5));
        }
    }

    public class Order
    {
        public string Description { get; set; }

        public int TotalValue { get; set; }

        private CalculateFinalPrice _CalculateFinalPrice;

        public Order(CalculateFinalPrice calculateFinalPrice)
        {
            _CalculateFinalPrice = calculateFinalPrice;
        }


        public int GetFinalValue()
        {

            int totalprice = _CalculateFinalPrice.Calculate(TotalValue);

            return totalprice;
        }
    }
}
