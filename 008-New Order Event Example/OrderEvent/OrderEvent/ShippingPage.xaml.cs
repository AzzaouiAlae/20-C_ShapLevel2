namespace OrderEvent;

public partial class ShippingPage : ContentPage
{
	public ShippingPage()
	{
		InitializeComponent();
        ClsOrder.OnOrderCreated += OrderCreated;
    }
    private void OrderCreated(object? sender, OrderCreatedEventArgs e)
    {
        ctrlShipping Shipping = new ctrlShipping(e);
        Shipping.on_DeleteClicked += DeleteClicked;
        vsl.Add(Shipping);
    }
    private void DeleteClicked(ctrlShipping Shipping)
    {
        vsl.Children.Remove(Shipping);
    }
}