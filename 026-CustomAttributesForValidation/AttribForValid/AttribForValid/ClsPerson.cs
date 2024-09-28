using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribForValid
{
    public class ClsPerson(byte age, string name)
    {
        [Range(18, 50, ErroreMessage = "The Age must be between 18 and 50")]
        public byte Age { get; set; } = age;
        public string? Name { get; set; } = name;
    }
}
