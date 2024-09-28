namespace OrderEvent;

public partial class ctrlSMS : ContentView
{
	public ctrlSMS()
	{
		InitializeComponent();
	}
    public ctrlSMS(OrderCreatedEventArgs e)
    {
        InitializeComponent();
        lbl_SMS.Text = "Order ID : " + e.OrderID + "\nProduct Name : " + e.ProductName + "\nTotal Price : " + e.TotalPrice;
    }
    public event Action<ctrlSMS>? on_DeleteClicked;
    private void btn_Delete_Clicked(object sender, EventArgs e)
    {
        on_DeleteClicked?.Invoke(this);
    }
}