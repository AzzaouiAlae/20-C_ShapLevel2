namespace SendDataToPage
{
    public partial class MainPage : ContentPage
    {
        int _PersonID;
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnPersonCard_Clicked(object sender, EventArgs e)
        {
            if (txt.Text == "")
                return;

            Navigation.PushAsync(new PersonCardPage(_PersonID));
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt.Text == "")
                return;

            if (!int.TryParse(txt.Text, out _PersonID))
                txt.Text = e.OldTextValue;
        }
    }

}
