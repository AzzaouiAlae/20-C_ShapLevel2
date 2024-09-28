using Microsoft.Maui.Controls;

namespace ProductControl;

public partial class CtrlProduct : ContentView
{
	public CtrlProduct()
	{
		InitializeComponent();
	}
    public class ProductEventArgs : EventArgs
    {
        public ImageSource imageSource { get; }
        public string ProductName { get; }
        public decimal Price { get; }
        public string EventResone { get; }

        public ProductEventArgs(ImageSource imageSource, string ProductName, decimal Price, string eventResone)
        {
            this.imageSource = imageSource;
            this.ProductName = ProductName;
            this.Price = Price;
            EventResone = eventResone;
        }
    }

    public event EventHandler<ProductEventArgs> OnProductClicked;
    
    protected virtual void ProductClicked(ProductEventArgs e)
    {
        OnProductClicked?.Invoke(this, e);
    }
    public void ProductClicked(ImageSource imageSource, string ProductName, decimal Price, string eventResone)
    {
        ProductClicked(new ProductEventArgs(imageSource, ProductName, Price, eventResone));
    }
    private void Image_Product_Clicked(object sender, EventArgs e)
    {
        decimal.TryParse(lbl_Price.Text.Replace("$", ""), out decimal price);
        ProductClicked(Image_Product.Source, lbl_Name.Text, price, "Image Product Clicked");
    }

    private void btn_Like_Clicked(object sender, EventArgs e)
    {
        decimal.TryParse(lbl_Price.Text.Replace("$",""), out decimal price);
        ProductClicked(Image_Product.Source, lbl_Name.Text, price, "btn Like Clicked");
    }
}