
namespace JewelryStore
{
    public interface IAccountDiscountCalculator
    {
        decimal ApplyDiscount(decimal totalPrice);
    }
}
