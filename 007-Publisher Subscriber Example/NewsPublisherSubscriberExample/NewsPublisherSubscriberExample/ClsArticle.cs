

namespace NewsPublisherSubscriberExample
{
    public class ClsArticle
    {
        public string Title { get; }
        public string Contant { get; }
        public ClsArticle(string title, string contant)
        {
            Title = title;
            Contant = contant;
            OnArticleCreate?.Invoke(this);
        }

        public static event Action<ClsArticle>? OnArticleCreate;
    }
}
