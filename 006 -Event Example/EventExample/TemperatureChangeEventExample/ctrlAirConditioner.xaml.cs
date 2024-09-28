namespace TemperatureChangeEventExample;

public partial class ctrlAirConditioner : ContentView
{
	public ctrlAirConditioner()
	{
		InitializeComponent();
	}

    public void Subscribe(clsThermostat Thermostat)
    {
        Thermostat.TemperatureChanged += Thermostat_TemperatureChanged;
    }
    private void Thermostat_TemperatureChanged(object sender, TemperatureChangeEventArgs e)
    {
        cb.IsChecked = e.NewTemperature >= 45? true : false;
    }
}