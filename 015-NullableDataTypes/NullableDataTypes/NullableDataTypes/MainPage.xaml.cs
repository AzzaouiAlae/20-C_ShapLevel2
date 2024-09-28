namespace NullableDataTypes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Nullable<int> x = null;
            if (x.HasValue)
                txt1.Text = x.ToString();
            else
                txt1.Text = "x is null";

            int? x1 = null;
            if (x1.HasValue)
                txt2.Text = x1.ToString();
            else
                txt2.Text = "x1 is null";

            txt3.Text = (x1 ?? 0).ToString();

            txt4.Text = x1?.ToString();
        }
    }

}
