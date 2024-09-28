using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExam
{
    public class TemperatureChangeEventArgs : EventArgs
    {
        public decimal OldTemperature { get; }
        public decimal NewTemperature { get; }
        public decimal Diffrence { get; }
        public TemperatureChangeEventArgs(decimal OldTemperature, decimal NewTemperature)
        {
            this.OldTemperature = OldTemperature;
            this.NewTemperature = NewTemperature;
            this.Diffrence = NewTemperature - OldTemperature;
        }
    }
    public class clsThermostat
    {
        public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;
        decimal OldTemperature { get; set; }
        decimal CurrentTemperature { get; set; }
        public decimal Temperature 
        {
            get { return CurrentTemperature; } 
            set
            {
                if(CurrentTemperature != value)
                {
                    OldTemperature = CurrentTemperature;
                    CurrentTemperature = value;
                    onTemperatureChange(OldTemperature, CurrentTemperature);
                }
            }
        }
        void onTemperatureChange(decimal OldTemperature, decimal CurrentTemperature)
        {
            onTemperatureChange(new TemperatureChangeEventArgs(OldTemperature, CurrentTemperature));
        }
        protected virtual void onTemperatureChange(TemperatureChangeEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
