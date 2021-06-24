using System;

namespace JewelryStore
{
    class PrintMethodFactory
    {
        internal static IPrint GetPrintMethod(char input)
        {
            IPrint print = null;
            switch (input)
            {
                case 'F':
                case 'f':
                    print = new PrintToFile();
                    break;
                case 'S':
                case 's':
                    print = new PrintToScreen();
                    break;
                case 'P':
                case 'p':
                    print = new PrintToPapper();
                    break;
                case 'x':
                case 'X':
                    Environment.Exit(1);
                    break;
                default:
                    throw new Exception("Invalid Option");
            }
            return print;
        }
    }
}
