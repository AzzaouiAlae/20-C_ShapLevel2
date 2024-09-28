using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace BinarySerialize
{
    [Serializable]
    public class ClsPerson
    {
        public string? Name { get; set; }
        public byte Age { get; set; }
        static public Action<ClsPerson>? Load { get; set; }
        public void LoadDataFromBin(string FileName)
        {
            
        }
        public void SaveDataToBin(string FileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
        }
        static public void LoadData(string FileName)
        {
            ClsPerson p = new();
            p.LoadDataFromBin(FileName);
            Load?.Invoke(p);
        }
    }
}
