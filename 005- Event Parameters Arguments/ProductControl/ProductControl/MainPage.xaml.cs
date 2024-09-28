namespace ProductControl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CtrlProduct_OnProductClicked(object sender, CtrlProduct.ProductEventArgs e)
        {
            lbl.Text = e.EventResone + "\n" + e.ProductName + "\n" + e.Price;
        }
    }

}
