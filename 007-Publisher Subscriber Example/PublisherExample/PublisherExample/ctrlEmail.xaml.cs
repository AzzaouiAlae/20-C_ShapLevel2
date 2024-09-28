namespace PublisherExample;

public partial class ctrlEmail : ContentView
{
	public ctrlEmail()
	{
		InitializeComponent();
	}
	public void Subscribe(ctrlPublisher Publishe)
	{
        Publishe.NewArticlePublished += Publishe_NewArticlePublished;
    }
    public void UnSubscribe(ctrlPublisher Publishe)
    {
        Publishe.NewArticlePublished -= Publishe_NewArticlePublished;
    }
    private void Publishe_NewArticlePublished(object? sender, NewArticle Article)
    {
        txt_Email.Text += Article.Title + "\n" + Article.Content + "\n\n";
    }
}