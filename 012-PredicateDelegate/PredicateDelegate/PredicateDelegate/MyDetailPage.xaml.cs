namespace PredicateDelegate;

public partial class MyDetailPage : ContentPage
{
	public MyDetailPage()
	{
		InitializeComponent();
		Globle.IsChecked = isChecked;

    }
	bool isChecked(bool x)
	{
		return chb.IsChecked;
	}
}