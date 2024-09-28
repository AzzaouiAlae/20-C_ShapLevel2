using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribForValid
{
    public class ClsValidation
    {
        static public bool Validation(ClsPerson Person, ref string msg)
        {
            Type type = typeof(ClsPerson);
            foreach(var Property in type.GetProperties())
            {
                if (Attribute.IsDefined(Property, typeof(RangeAttribute)))
                {
                    var range = (RangeAttribute?)Attribute.GetCustomAttribute(Property, typeof(RangeAttribute));
                    byte? Value = (byte?)Property.GetValue(Person);

                    if (Value < range?.Mini || Value > range?.Max)
                    {
                        msg = $"Validation Failed for property : {Property.Name} {range.ErroreMessage}";
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
