namespace TemperatureChangeEvent;

public partial class MyFlyoutPage : ContentPage
{
	public MyFlyoutPage()
	{
		InitializeComponent();
	}

    private void ctrlTempDisplay_Loaded(object sender, EventArgs e)
    {
        CtrlTemp.SubscribeOnTempEvent(ClsGlobal.Thermostat);
    }
}