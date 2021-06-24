using JewelryStore.DiscountManager;

namespace JewelryStore
{
    class PrivelegedUserDiscountCalculator : IAccountDiscountCalculator
    {
        decimal IAccountDiscountCalculator.ApplyDiscount(decimal totalPrice)
        {
            return (totalPrice - (DiscountPercentagesConstants.DISCOUNT_FOR_PrivelegedUsers * totalPrice));
        }
    }
}
