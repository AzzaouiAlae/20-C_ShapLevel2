using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace JsonSerialize
{
    [Serializable]
    public class ClsPerson
    {
        public string? Name { get; set; }
        public byte Age { get; set; }
        static public Action<ClsPerson>? Load { get; set; }
        public void LoadDataFromXml(string FileName)
        {
            DataContractJsonSerializer serializer = new(typeof(ClsPerson));
            using (FileStream stream = new(FileName, FileMode.Open))
            {
                ClsPerson p = (ClsPerson)serializer.ReadObject(stream);
                Name = p.Name;
                Age = p.Age;
            }
        }
        public void SaveDataFromXml(string FileName)
        {
            DataContractJsonSerializer serializer = new(typeof(ClsPerson));
            using (MemoryStream Stream = new())
            {
                serializer.WriteObject(Stream, this);
                string jsonString = Encoding.UTF8.GetString(Stream.ToArray());
                File.WriteAllText(FileName, jsonString);
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
