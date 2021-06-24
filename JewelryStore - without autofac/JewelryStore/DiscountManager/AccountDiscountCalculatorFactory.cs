

namespace JewelryStore
{
    class AccountDiscountCalculatorFactory 
    {
        internal static IAccountDiscountCalculator GetAccountDiscountCalculator(Enums.UserCategory accountStatus)
        {
            IAccountDiscountCalculator calculator =null;
            switch (accountStatus)
            {
                case Enums.UserCategory.Normal:
                    calculator = new NormalUserDiscountCalculator();
                    break;
                case Enums.UserCategory.Privileged:
                    calculator = new PrivelegedUserDiscountCalculator();
                    break;
            }
            return calculator;
        }
    }
}
