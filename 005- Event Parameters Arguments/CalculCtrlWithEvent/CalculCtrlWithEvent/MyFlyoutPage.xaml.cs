namespace CalculCtrlWithEvent;

public partial class MyFlyoutPage : ContentPage
{
	public MyFlyoutPage()
	{
		InitializeComponent();
	}
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        MyDetailsPage.OnCalculateComplete += MyDetailsPage_OnCalculateComplete;
    }
    private void MyDetailsPage_OnCalculateComplete(CalculatorEventArgs e)
    {
        lbl.Text = "Num1 : " + e.Num1 + "\n" + "Num2 : " + e.Num2 + "\n" + "Result : " + e.Result;
    }
}