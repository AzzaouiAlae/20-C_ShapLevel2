using System.Net;

namespace TaskClass2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Action actionS1 = () => { lbl1.Text = "Download Start"; };
            Action<string> actionE1 = (content) => { lbl1.Text = "Download Complete"; html1.Html = content; };
            Task task = DownloadWebUrlAsync("https://programmingadvices.com", actionS1, actionE1);

            Action actionS2 = () => { lbl2.Text = "Download Start"; };
            Action<string> actionE2 = (content) => { lbl2.Text = "Download Complete"; html2.Html = content; };
            Task task2 = DownloadWebUrlAsync("https://www.udemy.com/", actionS2, actionE2);

            //Action actionS3 = () => { lbl3.Text = "Download Start"; };
            //Action<string> actionE3 = (content) => { lbl3.Text = "Download Complete"; html3.Html = content; };
            //Task task3 = DownloadWebUrlAsync("https://programmingadvices.com", actionS3, actionE3);
        }
        async Task DownloadWebUrlAsync(string url, Action Start, Action<string> End)
        {
            string content = "";
            Start();
            using (WebClient client = new())
            {
                content = await client.DownloadStringTaskAsync(url);
            }
            End(content);
        }
    }

}
