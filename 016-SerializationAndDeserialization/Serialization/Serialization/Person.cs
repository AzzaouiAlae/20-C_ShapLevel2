using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public sbyte Age { get; set; }

        XmlSerializer Serializer = new (typeof(Person));
        public void SaveToFile()        
        {            
            using (TextWriter Write = new StreamWriter("C:\\person.xml"))
            {
                Serializer.Serialize(Write, this);
            }
        }
        
        public void GetDataFromFile() // Deserialize the object back
        {
            using (TextReader Reader= new StreamReader("C:\\person.xml"))
            {
                Person p = (Person)Serializer.Deserialize(Reader);
                Name = p.Name;
                Age = p.Age;
            }
        }

        static public Action<Person>? Load;

        public void LoadData()
        {
            GetDataFromFile();
            Load(this);
        }
    }
}
