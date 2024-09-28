using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    public class Globle
    {
        static public Predicate<bool>? IsChecked;
        static public Action<bool>? SetMyCheckBox;
    }
}
