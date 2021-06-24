using JewelryStore.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore
{
    class PrintToScreen : IPrint
    {
        public string PrintEstimation(IEstimationInput estimationInput, Enums.UserCategory userCategory)
        {
            ConsoleUtility.Print(Messages.GoldPricePerGram, estimationInput.GoldPricePerGram);

            ConsoleUtility.Print(Messages.WeightInGrams, estimationInput.Weight);

            if (userCategory.Equals(Enums.UserCategory.Privileged))
            {
                ConsoleUtility.Print(Messages.DiscountInPercentage, estimationInput.Discount);           
            }
            ConsoleUtility.Print(Messages.TotalPriceBeforeDiscount, estimationInput.TotalPriceAfterDiscount);
            return Messages.DataPopulated;
        }
    }
}
