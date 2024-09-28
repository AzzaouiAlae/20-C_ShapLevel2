using System.Xml.Linq;

namespace ControlsProperty;

public partial class HorsListOfProducts : ContentView
{
	public HorsListOfProducts()
	{
		InitializeComponent();
    }

    private void ContentView_Loaded(object sender, EventArgs e)
    {
        MinProductContent mpc = new MinProductContent();
        mpc.imageSource = ImageSource.FromFile("product.png");
        mpc.Name = "Product1";
        mpc.Price = "10$";
        mpc.onBtnAddToCardCliked += Mpc_onBtnAddToCardCliked;
        hsl.Add(mpc);

        MinProductContent mpc2 = new MinProductContent();
        mpc2.imageSource = ImageSource.FromFile("productt.png");
        mpc2.Name = "Product2";
        mpc2.Price = "20$";
        mpc2.onBtnAddToCardCliked += Mpc_onBtnAddToCardCliked;
        hsl.Add(mpc2);

        MinProductContent mpc3 = new MinProductContent();
        mpc3.imageSource = ImageSource.FromFile("producttt.png");
        mpc3.Name = "Product3";
        mpc3.Price = "30$";
        mpc3.onBtnAddToCardCliked += Mpc_onBtnAddToCardCliked;
        hsl.Add(mpc3);

        MinProductContent mpc4 = new MinProductContent();
        mpc4.imageSource = ImageSource.FromFile("productttt.png");
        mpc4.Name = "Product4";
        mpc4.Price = "40$";
        mpc4.onBtnAddToCardCliked += Mpc_onBtnAddToCardCliked;
        hsl.Add(mpc4);
    }

    private void Mpc_onBtnAddToCardCliked(string Name)
    {
        BtnAddToCardCliked(Name);
    }

    public event Action<string> onBtnAddToCardCliked;

    protected virtual void BtnAddToCardCliked(string name)
    {
        Action<string> Handler = onBtnAddToCardCliked;

        if (Handler != null)
            Handler(name);
    }
}