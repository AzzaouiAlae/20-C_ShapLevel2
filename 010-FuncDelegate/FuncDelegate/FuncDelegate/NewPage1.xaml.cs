namespace FuncDelegate;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        lbl.Text = Globale.Square(10).ToString();
    }
}