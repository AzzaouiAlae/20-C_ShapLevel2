namespace ActionDelegate;

public partial class MyDetailsPage : ContentPage
{
	public MyDetailsPage()
	{
		InitializeComponent();
		Globale.SetMyCheckBox = SetMyCheckBox;
    }
	void SetMyCheckBox(bool value)
	{
		chb.IsChecked = value;
	}
}