namespace SendDataBak;

public partial class SelectPersonPage : ContentPage
{
	int _PersonID = -1;
	public SelectPersonPage()
	{
		InitializeComponent();
	}
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		if (txt.Text == "")
			return;

		if (!int.TryParse(txt.Text, out _PersonID))
			txt.Text = e.OldTextValue;
    }

    public delegate void PersonIDBack(int PersonID);

    public event PersonIDBack PersonID_Back;
    private void btnOk_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(txt.Text, out _PersonID))
        {
            if(PersonID_Back != null)
                PersonID_Back(_PersonID);
        }

        Navigation.PopAsync();
    }
    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}