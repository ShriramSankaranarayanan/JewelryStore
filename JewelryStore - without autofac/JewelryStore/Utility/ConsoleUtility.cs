using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore.Utility
{
    class ConsoleUtility
    {
        private static void PrintInput<T>(T msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
        }

        private static void PrintLabel(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(msg);
        }
        internal static void Print<T>(string label,T input)
        {
            PrintLabel(label);
            PrintInput(input);

        }
    }
}
