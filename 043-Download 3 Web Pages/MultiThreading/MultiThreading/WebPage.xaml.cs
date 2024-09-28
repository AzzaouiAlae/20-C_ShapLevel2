

namespace MultiThreading;

public partial class WebPage : ContentPage
{
	public WebPage()
	{
		InitializeComponent();
	}
    public void SetHtml(string html)
    {
        Myhtml.Html = html;
    }

    private void vsl_SizeChanged(object sender, EventArgs e)
    {
        MyWb.HeightRequest = vsl.Height;
    }
}