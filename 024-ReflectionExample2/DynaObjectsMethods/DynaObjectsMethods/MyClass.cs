using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaObjectsMethods
{
    public class MyClass
    {
        public int Property1 { get; set; }
        public string? Property2 { get; set; }
        public string Methode1()
        {
            return "Method1 is executed";
        }
        public string Methode2(int value1, string value2)
        {
            return $"Methode2 is executed with parameters {value1} {value2}";
        }
    }
}
