

namespace ProductControl;

public partial class ctrlProduct : ContentView
{
	public ctrlProduct()
	{
		InitializeComponent();
	}
	public Image image
	{
		get { return ProductImg; }
		set { ProductImg = value; }
	}
    public ImageSource imageSource
    {
        get { return ProductImg.Source; }
        set { ProductImg.Source = value; }
    }
    public Label LblProductName
	{
        get { return lbl_ProductName; }
        set { lbl_ProductName = value; }
    }
    public string ProductName
    {
        get { return lbl_ProductName.Text; }
        set { lbl_ProductName.Text = value; }
    }

    public Label LblPrice
    {
        get { return lbl_Price; }
        set { lbl_Price = value; }
    }
    public string Price
    {
        get { return lbl_Price.Text; }
        set { lbl_Price.Text = value; }
    }
    public Label LblDecription
    {
        get { return lbl_Decription; }
        set { lbl_Decription = value; }
    }
    public string Decription
    {
        get { return lbl_Decription.Text; }
        set { lbl_Decription.Text = value; }
    }
}