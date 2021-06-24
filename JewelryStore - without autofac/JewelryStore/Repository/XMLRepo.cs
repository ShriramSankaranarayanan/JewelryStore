using System.Collections.Generic;

namespace JewelryStore
{
    class XMLRepo : IRepository<IUserModel>
    {
        private readonly IXMLParser<IUserModel> _XMLParser;
        protected internal XMLRepo()
        {
            _XMLParser = new XMLParserForUser();
        }
        public ICollection<IUserModel> GetData()
        {
            return _XMLParser.ParseXMLData();
        }
    }
}
