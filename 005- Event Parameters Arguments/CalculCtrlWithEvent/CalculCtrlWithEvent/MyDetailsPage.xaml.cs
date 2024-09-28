namespace CalculCtrlWithEvent;


public partial class MyDetailsPage : ContentPage
{
	public MyDetailsPage()
	{
		InitializeComponent();
	}

    static public event Action<CalculatorEventArgs>? OnCalculateComplete;
    static protected void CalculateComplete(CalculatorEventArgs Result)
    {
        Action<CalculatorEventArgs> ? Handel = OnCalculateComplete;

        OnCalculateComplete?.Invoke(Result);
    }
    private void CtrlCalcul_OnCalculateComplete(object sender, CalculatorEventArgs e)
    {
        lbl.Text = "Num1 : " + e.Num1 + "\n" + "Num2 : " + e.Num2 + "\n" + "Result : " + e.Result;
        CalculateComplete(e);
    }
}