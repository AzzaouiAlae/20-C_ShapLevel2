using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReflecCustomAttrib
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MyCustomAttribute(string description) : Attribute
    {
        public string Description { get; } = description;
    }
}
