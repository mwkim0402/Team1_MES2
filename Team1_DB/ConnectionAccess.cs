using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Reflection;

namespace Team1_DB
{
    public abstract class ConnectionAccess
    {
        protected string ConnectionString
        {
            get
            {
                string connStr = string.Empty;
                XmlDocument configXml = new XmlDocument();
                configXml.Load(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/DataBase_XML.xml");
                XmlNodeList addNodes = configXml.SelectNodes("configuration/settings/add");
                foreach (XmlNode xmlNode in addNodes)
                {
                    if (xmlNode.Attributes["key"].InnerText == "MyDB")
                    {
                        connStr = ((XmlCDataSection)xmlNode.ChildNodes[0]).InnerText;
                        break;
                    }
                }
                return connStr;
            }
        }
    }
}
