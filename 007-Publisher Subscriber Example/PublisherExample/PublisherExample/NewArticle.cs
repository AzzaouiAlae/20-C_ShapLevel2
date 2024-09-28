using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherExample
{
    public class NewArticle
    {
        public string Title { get; }
        public string Content { get; }
        public NewArticle(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
