namespace TemperatureChangeEvent;

public partial class MyDetailsPage : ContentPage
{
	public MyDetailsPage()
	{
		InitializeComponent();
	}

    private void btn_SetTemp_Clicked_1(object sender, EventArgs e)
    {
		if(short.TryParse(txt_Temp.Text, out short Temp))
			ClsGlobal.Thermostat.Temperature = Temp;
    }
}