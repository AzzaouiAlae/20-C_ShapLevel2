namespace OrderEvent;

public partial class AddProductPage : ContentPage
{
	public AddProductPage()
	{
		InitializeComponent();
	}

    private void btn_AddProduct_Clicked(object sender, EventArgs e)
    {
        int OrderID;
        if (!int.TryParse(txt_OrderID.Text, out OrderID))
            return;

        decimal TotalPrice;
        if (!decimal.TryParse(txt_TotalPrice.Text, out TotalPrice))
            return;

        ClsOrder Order = new ClsOrder(OrderID, TotalPrice, txt_ProductName.Text);
    }
}