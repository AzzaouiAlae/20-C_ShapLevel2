namespace NewOrderEventExample;

public partial class CtrlShippingList : ContentView
{
	public CtrlShippingList()
	{
		InitializeComponent();
	}
    public void SubScribe()
    {
        ClsOrder.OrderAdded += ClsOrder_OrderAdded;
    }
    private void ClsOrder_OrderAdded(object? sender, NewOrderEventArgs e)
    {
        CtrlShipping Ship = new(e.OrderID, e.TotalPrice, e.ProductName);
        Ship.OrderShipped += Ship_OrderShipped;
        hsl.Add(Ship);
    }
    private void Ship_OrderShipped(CtrlShipping order)
    {
        hsl.Children.Remove(order);        
    }
    private void ContentView_Loaded(object sender, EventArgs e)
    {
        SubScribe();
    }
}