namespace TemperatureChangeEvent;

public partial class ctrlListOfTempChange : ContentView
{
	public ctrlListOfTempChange()
	{
		InitializeComponent();
	}
	ctrlTempDisplay Temp = new ctrlTempDisplay();
    private void ContentView_Loaded(object sender, EventArgs e)
    {
		Temp.SubscribeOnTempEvent(ClsGlobal.Thermostat);
        ClsGlobal.Thermostat.OnTempratureChange += Thermostat_OnTempratureChange;
    }

    private void Thermostat_OnTempratureChange(object? sender, TempratureChangeEventArgs e)
    {
        hsl.Add(Temp);
        Temp.UnSubscribeOnTempEvent(ClsGlobal.Thermostat);
        Temp = new ctrlTempDisplay();
        Temp.SubscribeOnTempEvent(ClsGlobal.Thermostat);
    }
}