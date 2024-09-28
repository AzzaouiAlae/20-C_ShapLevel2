using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [Serializable]
    public class ClsPerson
    {
        public string? Name { get; set; }
        public byte Age { get; set; }
        static public Action<ClsPerson>? Load { get; set; }
        public void LoadDataFromXml(string FileName)
        {
            XmlSerializer serializer = new(typeof(ClsPerson));
            using (TextReader Reder =  new StreamReader(FileName))
            {
                ClsPerson p = (ClsPerson)serializer.Deserialize(Reder);
                Name = p.Name; Age = p.Age;
            }
        }
        public void SaveDataFromXml(string FileName)
        {
            XmlSerializer serializer = new(typeof(ClsPerson));
            using (TextWriter Writer = new StreamWriter(FileName))
            {
                serializer.Serialize(Writer, this);
            }
        }
        static public void LoadData(string FileName)
        {
            ClsPerson p = new();
            p.LoadDataFromXml(FileName);
            Load?.Invoke(p);
        }
    }

}
