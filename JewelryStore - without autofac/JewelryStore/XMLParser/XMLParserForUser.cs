using System;
using System.Collections.Generic;
using System.Xml;


namespace JewelryStore
{
    class XMLParserForUser : IXMLParser<IUserModel>
    {       
        public ICollection<IUserModel> ParseXMLData()
        {
            XmlDocument XmlDoc = new XmlDocument();
            string path = AppsettingReader.ReadSetting("XMLStoragePath");

            LoadXMLFrom_the_Path(XmlDoc, path);

            var XmlDocNodes = GetSelectedNodes(XmlDoc);

            return CreateUserModelList(XmlDocNodes);
        }

        private XmlNodeList GetSelectedNodes(XmlDocument XmlDoc) => XmlDoc.SelectNodes(AppsettingReader.ReadSetting("XmlDocNodes"));

        private  void LoadXMLFrom_the_Path(XmlDocument XmlDoc, string path)
        {
            try
            {
                XmlDoc.Load(path);
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new Exception(Messages.FileNotFound);
            }
            catch (System.ArgumentException)
            {
                throw new Exception(Messages.InvalidPath);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        private ICollection<IUserModel> CreateUserModelList(XmlNodeList XmlDocNodes)
        {
            var userList = new List<IUserModel>();

            foreach (XmlNode node in XmlDocNodes)
            {
                IUserModel obj = new UserModel
                {
                    Id = int.Parse(node["Id"].InnerText),
                    UserName = node["UserName"].InnerText,
                    Password = node["Password"].InnerText
                };
                if (Enum.TryParse(node["UserCategory"].InnerText, out Enums.UserCategory result))
                    obj.UserCategory = result;
                userList.Add(obj);
            }

            return userList;
        }

    }
}
