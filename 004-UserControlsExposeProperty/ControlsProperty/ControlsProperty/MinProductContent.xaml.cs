using System.Xml.Linq;

namespace ControlsProperty;

public partial class MinProductContent : ContentView
{
	public MinProductContent()
	{
		InitializeComponent();
	}

	public ImageSource imageSource
	{	get { return ProductImg.Source; }
		set { ProductImg.Source = value; }
	}
    public string Name
    {
        get { return lbl_Name.Text; }
        set { lbl_Name.Text = value; }
    }
    public string Price
    {
        get { return lbl_Price.Text; }
        set { lbl_Price.Text = value; }
    }

    public event Action<string> onBtnAddToCardCliked;

    protected virtual void BtnAddToCardCliked(string name)
    {
        Action<string> Handler = onBtnAddToCardCliked;

        if (Handler != null)
            Handler(name);
    }
    private void btn_AddToCard_Clicked(object sender, EventArgs e)
    {
        if (onBtnAddToCardCliked != null)
            BtnAddToCardCliked(Name);
    }
}