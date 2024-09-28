using Microsoft.UI.Xaml.Controls.Primitives;

namespace SendDataBack;

public partial class SelectPersonPage : ContentPage
{
    int _PersonID;
	public SelectPersonPage()
	{
		InitializeComponent();
	}

    public delegate void SendPersonID(int PersonID);

    public event SendPersonID PersonID_Back;
    private void btnOk_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(txt.Text, out _PersonID))
            PersonID_Back?.Invoke(_PersonID);
        Navigation.PopAsync();
    }

    private void btnCancele_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}