using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClassWithEvent
{
    public class PersonEventArgs(string name, byte age) : EventArgs
    {
        public string Name { get; } = name;
        public byte Age { get; } = age;
    }
}
