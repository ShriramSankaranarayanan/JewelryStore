namespace JewelryStore
{
    static class TotalPriceCalculator
    {
        internal static decimal CalculateTotalPrice(decimal goldPricePerGram,decimal weight)
        {
            return goldPricePerGram * weight;
        }
    }
}
