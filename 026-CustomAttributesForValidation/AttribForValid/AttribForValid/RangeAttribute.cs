using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribForValid
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute(byte mini, byte max) : Attribute
    {
        public byte Max { get; } = max;
        public byte Mini { get; } = mini;
        public string? ErroreMessage { get; set; }
    }
}
