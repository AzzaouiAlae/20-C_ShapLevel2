namespace OrderEvent;

public partial class ctrlEmail : ContentView
{
	public ctrlEmail()
	{
		InitializeComponent();
	}
    public ctrlEmail(OrderCreatedEventArgs e)
    {
        InitializeComponent();
        lbl_Email.Text = "Order ID : " + e.OrderID + "\nProduct Name : " + e.ProductName + "\nTotal Price : " + e.TotalPrice;
    }
    public event Action<ctrlEmail>? on_DeleteClicked;
    private void btn_Delete_Clicked(object sender, EventArgs e)
    {
        on_DeleteClicked?.Invoke(this);
    }
}