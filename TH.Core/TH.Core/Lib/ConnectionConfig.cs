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
        public int ID;
        public string ConfigName;
        public string Server;
        public string UserName;
        public string Password;
        public string Database;
        public string BackupFolderPath;
        public string BackupFileName;
        public List<string> DailyBackupTime;
        bool IsDailyBackup = false;

    }
    
    public static class XmlController
    {
        //private static string _path = "config.xml";
        public static void SaveSqlConnectionConfigToXMLFile(List<SqlConnectionConfig> obj, string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<SqlConnectionConfig>));
                TextWriter writer = new StreamWriter(path);                
                serializer.Serialize(writer, obj);
                writer.Close();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<SqlConnectionConfig> LoadSqlConnectionConfigFromXMLFile(string path)
        {
            List<SqlConnectionConfig> list = new List<SqlConnectionConfig>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<SqlConnectionConfig>));
            using (StreamReader reader = new StreamReader(path))
            {
                list = (List<SqlConnectionConfig>)serializer.Deserialize(reader);
            }
            return list;
        }
    }
}
