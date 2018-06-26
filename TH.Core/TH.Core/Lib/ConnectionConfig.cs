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
        public string Port;
        public string UserName;
        public string Password;
        public string Database;
        
    }
    public static class XmlController
    {
        //private static string _path = "config.xml";
        public static void SaveSqlConnectionConfigToXMLFile(SqlConnectionConfig obj, string path)
        {            
            XmlSerializer serializer = new XmlSerializer(typeof(SqlConnectionConfig));
            TextWriter writer = new StreamWriter(path);                
            serializer.Serialize(writer, obj);
            writer.Close();            
        }
        public static void SaveSqlObjectToXMLFile(object obj, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(object));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, obj);
            writer.Close();
        }


        public static SqlConnectionConfig LoadSqlConnectionConfigXMLToObject(string path)
        {
            SqlConnectionConfig config = new SqlConnectionConfig();
            XmlSerializer serializer = new XmlSerializer(typeof(SqlConnectionConfig));
            TextReader reader = new StreamReader(path);
            config = (SqlConnectionConfig)serializer.Deserialize(reader);
            reader.Close();
            return config;            
        }
    }
}
