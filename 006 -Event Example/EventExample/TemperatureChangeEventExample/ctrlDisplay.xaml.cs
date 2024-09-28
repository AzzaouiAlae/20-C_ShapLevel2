namespace TemperatureChangeEventExample;

public partial class ctrlDisplay : ContentView
{
	public ctrlDisplay()
	{
		InitializeComponent();
	}
    public void Subscribe(clsThermostat Thermostat)
    {
        Thermostat.TemperatureChanged += Thermostat_TemperatureChanged;
    }
    private void Thermostat_TemperatureChanged(object sender, TemperatureChangeEventArgs e)
    {
        lbl_OldTemperature.Text = "Old Temperature = " + e.OldTemperature + "C°";
        lbl_NewTemperature.Text = "New Temperature = " + e.NewTemperature + "C°";
        lbl_Diffrence.Text = "Diffrence = " + e.Diffrence + "C°";
    }
}