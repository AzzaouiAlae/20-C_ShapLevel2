namespace NewsPublisherSubscriberExample;

public partial class NewsList : ContentView
{
	public NewsList()
	{
		InitializeComponent();
	}

    private void ContentView_Loaded(object sender, EventArgs e)
    {
        ClsArticle.OnArticleCreate += ArticleCreated;
    }

    private void ArticleCreated(ClsArticle Article)
    {
        ctrlDisplay Display = new ();
        Display.SetArticle(Article);
        hsl.Add(Display);
    }
}