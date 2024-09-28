namespace OrderEvent;

public partial class ctrlShipping : ContentView
{
	public ctrlShipping()
	{
		InitializeComponent();
	}
    public ctrlShipping(OrderCreatedEventArgs e)
    {
        InitializeComponent();
        lbl_Shipping.Text = "Order ID : " + e.OrderID + "\nProduct Name : " + e.ProductName + "\nTotal Price : " + e.TotalPrice;
    }
    public event Action<ctrlShipping>? on_DeleteClicked;
    private void btn_Delete_Clicked(object sender, EventArgs e)
    {
        on_DeleteClicked?.Invoke(this);
    }
}