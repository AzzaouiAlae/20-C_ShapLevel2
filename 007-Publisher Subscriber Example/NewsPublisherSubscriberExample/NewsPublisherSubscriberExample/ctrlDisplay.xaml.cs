namespace NewsPublisherSubscriberExample;

public partial class ctrlDisplay : ContentView
{
	public ctrlDisplay()
	{
		InitializeComponent();
	}
	public string Title
	{
		get { return lbl_Title.Text; } 
		set { lbl_Title.Text = value;}
	}
    public string Contant
    {
        get { return lbl_Contant.Text; }
        set { lbl_Contant.Text = value; }
    }
	public void SetArticle(ClsArticle article)
	{
        Title = article.Title;
		Contant = article.Contant;
    }
}