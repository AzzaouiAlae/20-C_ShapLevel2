namespace NewOrderEventExample;

public partial class CtrlEmail : ContentView
{
	public CtrlEmail()
	{
		InitializeComponent();
	}
	public void SubScribe()
	{
        ClsOrder.OrderAdded += ClsOrder_OrderAdded;
	}
    public void UnsubScribe()
    {
        ClsOrder.OrderAdded -= ClsOrder_OrderAdded;
    }
    private void ClsOrder_OrderAdded(object? sender, NewOrderEventArgs e)
    {
        txt_Email.Text += "Order ID = " + e.OrderID + "\n" + 
                          "Total Price = " + e.TotalPrice + "\n" + 
                          "Product Name = " + e.ProductName + "\n\n";
    }
    private void ContentView_Loaded(object sender, EventArgs e)
    {
        SubScribe();
    }
}