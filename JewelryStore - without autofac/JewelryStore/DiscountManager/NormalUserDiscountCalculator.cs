using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore
{
    class NormalUserDiscountCalculator : IAccountDiscountCalculator
    {
        decimal IAccountDiscountCalculator.ApplyDiscount(decimal price)
        {
            return price;
        }
    }
}
