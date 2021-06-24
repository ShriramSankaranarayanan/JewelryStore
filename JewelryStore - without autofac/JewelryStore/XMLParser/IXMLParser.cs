using System.Collections.Generic;

namespace JewelryStore
{
    interface IXMLParser<T> where T:class
    {
        ICollection<T> ParseXMLData();
    }
}