namespace PublisherExample;

public partial class ctrlPublisher : ContentView
{
	public ctrlPublisher()
	{
		InitializeComponent();
	}

    public event EventHandler<NewArticle> NewArticlePublished;
	void PublishNews()
	{
		var Artical = new NewArticle(txt_Title.Text, txt_Content.Text);
		onNewArticlePublished(Artical);
    }
	
	protected virtual void onNewArticlePublished(NewArticle newArticle)
	{
        NewArticlePublished?.Invoke(this, newArticle);
    }

    private void btn_Publish_Clicked(object sender, EventArgs e)
    {
		PublishNews();
    }
}