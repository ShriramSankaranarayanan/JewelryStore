using System.IO;

namespace JewelryStore
{
    class PrintToFile : IPrint
    {
        public string PrintEstimation(IEstimationInput estimationInput, Enums.UserCategory userCategory)
        {
            string filePath = AppsettingReader.ReadSetting("FileStoragePath");
            using (var writer = new StreamWriter(filePath))
            {
                // Write format string to file.
                writer.WriteLine($"{Messages.GoldPricePerGram} : {estimationInput.GoldPricePerGram}");
                writer.WriteLine($"{Messages.WeightInGrams} : {estimationInput.Weight}");
                if (userCategory.Equals(Enums.UserCategory.Privileged))
                {
                    writer.WriteLine($"{Messages.DiscountInPercentage} : {estimationInput.Discount}");
                }
                writer.WriteLine($"{Messages.TotalPriceBeforeDiscount} : {estimationInput.TotalPriceAfterDiscount}");
            }
            return Messages.DataPopulated; 
        }
    }
}
