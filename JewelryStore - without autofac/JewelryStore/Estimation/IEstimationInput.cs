namespace JewelryStore
{
    interface IEstimationInput
    {
        decimal GoldPricePerGram { get; set; }
        decimal TotalPriceAfterDiscount { get; set; }
        decimal TotalPriceBeforeDiscount { get; set; }
        decimal Weight { get; set; }

        decimal Discount { get; set; }
        void Calculate(Enums.UserCategory userCategory);

    }
}