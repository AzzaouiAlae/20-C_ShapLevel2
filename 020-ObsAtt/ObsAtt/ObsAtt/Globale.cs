using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObsAtt
{
    public class Globale
    {
        [Obsolete("This method is marked as obsolete, and will be deprecated in the future.")]
        public static string AbbsMethod()
        {
            return "Hello this is the Test of absolete method";
        }
    }
}
