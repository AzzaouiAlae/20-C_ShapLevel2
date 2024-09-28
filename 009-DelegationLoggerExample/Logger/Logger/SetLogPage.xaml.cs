namespace Logger;

public partial class SetLogPage : ContentPage
{
	public SetLogPage()
	{
		InitializeComponent();
	}
	void ThisIsNewLogger(string Message)
	{
		lbl_Log.Text = Message;
    }
    private void btn_Logger_Clicked(object sender, EventArgs e)
    {
        ClsGlobale.log.Log(txt_SetLog.Text);
    }
}