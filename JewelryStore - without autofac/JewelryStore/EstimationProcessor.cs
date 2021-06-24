using JewelryStore.Utility;
using System;

namespace JewelryStore
{
    class EstimationProcessor : IEstimationProcessor
    {
        private readonly Enums.UserCategory _userCategory;
        private IEstimationInput estimation;
        private EstimationProcessor(Enums.UserCategory userCategory)
        {
            _userCategory = userCategory;
        }
        public static IEstimationProcessor GetInstance(Enums.UserCategory userCategory)
        {
            return new EstimationProcessor(userCategory);
        }
        public void Process()
        {
            estimation = GetEstimationInputs();

            GetTotalPriceAfterDiscount();

            DisplayEstimation( );

            DisplayMenu( );
        }

        #region Estimation Related methods
        private  void GetTotalPriceAfterDiscount()
        {
            estimation.Calculate(_userCategory);
        }

        private  void DisplayEstimation()
        {
            ConsoleUtility.Print(Messages.GoldPricePerGram, estimation.GoldPricePerGram);

            ConsoleUtility.Print(Messages.WeightInGrams, estimation.Weight);

            ConsoleUtility.Print(Messages.TotalPriceBeforeDiscount, estimation.TotalPriceBeforeDiscount);

            if (_userCategory.Equals(Enums.UserCategory.Privileged))
            {
                ConsoleUtility.Print(Messages.DiscountInPercentage, estimation.Discount);
            }
        }

        private  IEstimationInput GetEstimationInputs()
        {
            IEstimationInputGetter estimationGetter = new EstimationInputGetter();
            var estimation = estimationGetter.GetGoldPriceAndWeight();
            estimation.TotalPriceBeforeDiscount = TotalPriceCalculator.CalculateTotalPrice(estimation.GoldPricePerGram, estimation.Weight);
            return estimation;
        }

        private  void DisplayMenu()
        {
            Console.WriteLine(Messages.Menu);
            var menu = Convert.ToChar(Console.ReadLine());
            var printMethod = PrintMethodFactory.GetPrintMethod(menu);
            string successMessage = printMethod.PrintEstimation(estimation, _userCategory);
            Console.WriteLine(successMessage);
        }

        #endregion
    }
}
