using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorDelegation.ClsCalculator;

namespace CalculatorDelegation
{
    public class ClsCalculator(ResultAction resultAction)
    {
        decimal _Result;
        //public decimal Result { get { return _Result;} }
        public void Addition(decimal Num)
        {
            _Result += Num;
        }
        public void Subtraction(decimal Num)
        {
            _Result -= Num;
        }
        public void Multiplication(decimal Num)
        {
            _Result *= Num;
        }
        public void Division(decimal Num)
        {
            _Result /= Num;
        }
        public delegate void ResultAction(decimal Result);

        public ResultAction resultAction = resultAction;
        public void Result()
        {
            resultAction(_Result);
        }
    }
}
