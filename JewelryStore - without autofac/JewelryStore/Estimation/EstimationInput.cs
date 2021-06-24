using JewelryStore.DiscountManager;
using System;

namespace JewelryStore
{
    class EstimationInput : IEstimationInput
    {
        private decimal _goldPricePerGram;
        public decimal GoldPricePerGram
        {
            get { return _goldPricePerGram; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception(Messages.GoldPricePerGramGreaterThanZero);
                }
                _goldPricePerGram = value;
            }
        }

        private decimal _weight;
        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception(Messages.WeightInGramsGreaterThanZero);
                }
                _weight = value;
            }
        }
        public decimal TotalPriceBeforeDiscount { get; set; }
        public decimal TotalPriceAfterDiscount { get; set; }
        public decimal Discount { get; set; }
        public void Calculate(Enums.UserCategory userCategory)
        {
            IAccountDiscountCalculator accountDiscountCalculator = AccountDiscountCalculatorFactory.GetAccountDiscountCalculator(userCategory);
            TotalPriceAfterDiscount = accountDiscountCalculator.ApplyDiscount(TotalPriceBeforeDiscount);
            Discount = DiscountPercentagesConstants.DISCOUNT_FOR_PrivelegedUsers * 100;
        }
    }
}
