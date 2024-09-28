namespace CalculCtrlWithEvent;

public class CalculatorEventArgs(decimal num1, decimal num2, decimal result) : EventArgs
{
    public decimal Num1 { get; } = num1;
    public decimal Num2 { get; } = num2;
    public decimal Result { get; } = result;
}
public partial class CtrlCalcul : ContentView
{
    public CtrlCalcul()
    {
        InitializeComponent();
    }
    private void Btn_Calcul_Clicked(object sender, EventArgs e)
    {
        decimal D1, D2;

        if (!decimal.TryParse(Txt1.Text, out D1))
            return;

        if (!decimal.TryParse(Txt2.Text, out D2))
            return;

        lbl_Result.Text = (D1 + D2).ToString();

        CalculateComplete(new CalculatorEventArgs(D1, D2, (D1 + D2)));
    }

    public event EventHandler<CalculatorEventArgs>? OnCalculateComplete;
    protected virtual void CalculateComplete(CalculatorEventArgs e)
    {
        EventHandler<CalculatorEventArgs> ? Handler = OnCalculateComplete;

        OnCalculateComplete?.Invoke(this, e);
    }
}