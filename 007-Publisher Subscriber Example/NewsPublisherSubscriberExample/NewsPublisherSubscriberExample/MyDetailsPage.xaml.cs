namespace NewsPublisherSubscriberExample;

public partial class MyDetailsPage : ContentPage
{
	public MyDetailsPage()
	{
		InitializeComponent();
	}

    private void btn_Publish_Clicked(object sender, EventArgs e)
    {
		ClsArticle Article = new(txt_Title.Text, txt_Contant.Text);
    }
}