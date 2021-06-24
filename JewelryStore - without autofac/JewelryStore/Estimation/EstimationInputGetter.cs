using System;
using System.Collections.Generic;
using System.Linq;


namespace JewelryStore
{
    class EstimationInputGetter : IEstimationInputGetter
    {
        private readonly IEstimationInput _estimation;

        public EstimationInputGetter()
        {
            this._estimation = new EstimationInput();
        }

        public IEstimationInput GetGoldPriceAndWeight()
        {
            GetGoldPricePerGram();

            GetWeightInGrams();

            return _estimation;
        }

        private void GetGoldPricePerGram()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Messages.EnterGoldPricePerGram);
            Console.ForegroundColor = ConsoleColor.Yellow;
            _estimation.GoldPricePerGram = Convert.ToDecimal( Console.ReadLine());
        }

        private void GetWeightInGrams()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Messages.EnterWeightInGrams);
            Console.ForegroundColor = ConsoleColor.Yellow;
            _estimation.Weight = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
