namespace NewOrderEventExample;

public partial class CtrlShipping : ContentView
{
	public CtrlShipping()
	{
		InitializeComponent();
	}
    public CtrlShipping(int OrderID, decimal TotalPrice, string ProductName)
    {
        InitializeComponent();

        txt_OrderID.Text = OrderID.ToString();
        txt_TotalPrice.Text = TotalPrice.ToString();
        txt_ProductName.Text = ProductName.ToString();
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
        txt_OrderID.Text = e.OrderID.ToString();
        txt_TotalPrice.Text = e.TotalPrice.ToString();
        txt_ProductName.Text = e.ProductName.ToString();
    }
    private void ContentView_Loaded(object sender, EventArgs e)
    {
        
    }

    public event Action<CtrlShipping>? OrderShipped;
    protected virtual void OrderShippedClicked(CtrlShipping Ctrl)
    {
        Action<CtrlShipping> ? Handler = OrderShipped;
        OrderShipped?.Invoke(Ctrl);
    }
    private void Btn_OrderShipped_Clicked(object sender, EventArgs e)
    {
        OrderShippedClicked(this);
    }
}