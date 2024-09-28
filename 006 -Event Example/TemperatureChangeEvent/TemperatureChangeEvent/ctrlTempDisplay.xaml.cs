namespace TemperatureChangeEvent;

public partial class ctrlTempDisplay : ContentView
{
	public ctrlTempDisplay()
	{
		InitializeComponent();
	}
	public void SubscribeOnTempEvent(ClsThermostat Thermostat)
	{
        Thermostat.OnTempratureChange += Thermostat_OnTempratureChange;

    }
    public void UnSubscribeOnTempEvent(ClsThermostat Thermostat)
    {
        Thermostat.OnTempratureChange -= Thermostat_OnTempratureChange;
    }
    private void Thermostat_OnTempratureChange(object? sender, TempratureChangeEventArgs e)
    {
        lbl_From.Text = e.OldTemprature.ToString();
        lbl_To.Text = e.NewTemprature.ToString();
        lbl_Differance.Text = e.DiferanceTemprature.ToString();
    }
}