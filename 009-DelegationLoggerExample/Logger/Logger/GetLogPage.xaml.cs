namespace Logger;

public partial class GetLogPage : ContentPage
{
	public GetLogPage()
	{
		InitializeComponent();
        ClsGlobale.log = new (Message => lbl_Log.Text = Message);
    }
}