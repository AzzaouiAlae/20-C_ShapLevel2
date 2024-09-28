namespace HashingExample;

public partial class LoginPage : ContentPage
{
    string _username = "";
    string _pass = "";
    public LoginPage(string username, string pass)
	{
		InitializeComponent();
        _username = username;
        _pass = pass;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if(txt_Username.Text != _username)
        {
            lbl_Result.Text = "invalid username/password";
            return;
        }
        if (MainPage.ComputeHash(txt_Password.Text) != _pass)
        {
            lbl_Result.Text = "invalid username/password";
            return;
        }
        lbl_Result.Text = "Login";
    }
}