using System.Net;

namespace TaskRunTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Start_Clicked(object sender, EventArgs e)
        {
            Action action1 = () => { lbl_ProgAvices.Text = "Download of ProgrammingAdvices Start..."; };
            Action<string> action2 = (contant) => { lbl_ProgAvices.Text = "Download of ProgrammingAdvices Complete";  myHtmlSource1.Html = contant; };
            Task t = Task.Run(() => DownloadUrl("https://programmingadvices.com", action1, action2));

            Action action3 = () => { lbl_Google.Text = "Download of Google Start..."; };
            Action<string> action4 = (contant) => { lbl_Google.Text = "Download of Google Complete"; myHtmlSource2.Html = contant; };
            Task t2 = Task.Run(() => DownloadUrl("https://Google.com", action3, action4));
        }
        async void DownloadUrl(string url, Action action1, Action<string> action2)
        {
            await MainThread.InvokeOnMainThreadAsync(action1);
            string contant = "";
            using(WebClient client = new())
            {
                contant = await client.DownloadStringTaskAsync(url);
            }
            await MainThread.InvokeOnMainThreadAsync(() => action2(contant));
        }
    }

}
