namespace ActionDelegate;

public partial class MyFloutPage : ContentPage
{
	public MyFloutPage()
	{
		InitializeComponent();
	}
	bool check = false;
    private void Button_Clicked(object sender, EventArgs e)
    {
        check = !check;
		Globale.SetMyCheckBox?.Invoke(check);
    }
}