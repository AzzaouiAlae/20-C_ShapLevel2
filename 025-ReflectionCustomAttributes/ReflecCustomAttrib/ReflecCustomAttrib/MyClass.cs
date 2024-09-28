using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflecCustomAttrib
{
    [MyCustom("Hello world this is my test of class Attribute")]
    public class MyClass
    {
        [MyCustom("Hello world this is my test of method Attribute")]
        static public void MyMethod()
        {

        }
    }
}
