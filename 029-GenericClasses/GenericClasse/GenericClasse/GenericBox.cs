using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasse
{
    public class GenericBox<T>(T contant)
    {
        T Contant = contant;

        public T Value { get { return Contant; } set { Contant = value; } }
    }
}
