namespace SendDataToPage;

public partial class PersonCardPage : ContentPage
{
	int _PersonID;

    public PersonCardPage(int PersonID)
	{
		InitializeComponent();
		_PersonID = PersonID;
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
		txt.Text = "Person ID = " + _PersonID.ToString();
    }
}