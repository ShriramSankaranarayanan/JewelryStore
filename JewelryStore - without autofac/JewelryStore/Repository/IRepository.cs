using System.Collections.Generic;

namespace JewelryStore
{
    interface IRepository<T> where T : class
    {
        ICollection<T> GetData();
    }
}