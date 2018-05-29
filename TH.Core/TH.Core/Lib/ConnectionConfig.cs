using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TH.Core.Lib
{
    public class SqlConnectionConfig
    {
        public string Server;
        public string UserName;
        public string Password;
        public string Database;
    }
    public static class XmlController
    {
        //private static string _path = "config.xml";
        public static void SaveSqlConnectionConfigToXMLFile(SqlConnectionConfig obj, string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SqlConnectionConfig));
                TextWriter writer = new StreamWriter(path);                
                serializer.Serialize(writer, obj);
                writer.Close();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
