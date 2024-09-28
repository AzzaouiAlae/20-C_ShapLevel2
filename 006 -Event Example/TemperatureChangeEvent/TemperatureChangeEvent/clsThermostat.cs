using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureChangeEvent
{
    public class TempratureChangeEventArgs(short oldTemprature, short newTemprature) : EventArgs
    {
        public short OldTemprature { get; } = oldTemprature;
        public short NewTemprature { get; } = newTemprature;
        public short DiferanceTemprature { get; } = (short)(newTemprature - oldTemprature);
    }
    public class ClsThermostat
    {
        public event EventHandler<TempratureChangeEventArgs>? OnTempratureChange;

        short OldTemprature;

        short CurrentTemprature;
        public short Temperature 
        {
            get {  return CurrentTemprature; }
            set 
            { 
                if(CurrentTemprature != value)
                {
                    OldTemprature = CurrentTemprature;
                    CurrentTemprature = value;
                    TempratureChange(new TempratureChangeEventArgs(OldTemprature, CurrentTemprature));
                }
            }
        }
        protected virtual void TempratureChange(TempratureChangeEventArgs e)
        {
            OnTempratureChange?.Invoke(this, e);
        }
    }
}
