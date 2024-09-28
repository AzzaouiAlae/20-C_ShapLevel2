namespace NewOrderEventExample;

public partial class MyDetailsPage : ContentPage
{
	public MyDetailsPage()
	{
		InitializeComponent();
	}

    private void Btn_NewOrder_Clicked(object sender, EventArgs e)
    {
        bool Result;

        Result = int.TryParse(txt_OrderID.Text, out int orderID);
        if (!Result) return;

        Result = decimal.TryParse(txt_TotalPrice.Text, out decimal TotalPrice);
        if (!Result) return;

        ClsOrder Order = new(orderID, TotalPrice, txt_ProductName.Text);
    }
}