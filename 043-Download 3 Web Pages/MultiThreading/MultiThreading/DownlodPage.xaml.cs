using System;
using System.Net;
using System.Security.Cryptography;

namespace MultiThreading;

public partial class DownlodPage : ContentPage
{
	public DownlodPage()
	{
		InitializeComponent();
	}
    private void btn_Start_Clicked(object sender, EventArgs e)
    {
        Thread t = new Thread(() => StartDownloadPage("https://programmingadvices.com/", (html) => MainPage.webPage_ProgAdvices.SetHtml(html)));
        t.Start();

        Thread t2 = new Thread(() => StartDownloadPage("https://programmingadvices.com/", (html) => MainPage.webPage_CNN.SetHtml(html)));
        t2.Start();

        //Thread t3 = new Thread(() => StartDownloadPage("https://www.udemy.com/", (html) => MainPage.webPage_Amazone.SetHtml(html)));
        //t3.Start();
    }

    void StartDownloadPage(string url, Action<string> Complet)
    {         
        string Content = "";
        Thread t = new Thread(() => DownloadPage(url, ref Content));
        t.Start();
        t.Join();
        Complet(Content);
    }

    void DownloadPage(string url, ref string Content)
	{
		using(WebClient Client = new ())
		{
            Content = Client.DownloadString(url);
        }
	}
}