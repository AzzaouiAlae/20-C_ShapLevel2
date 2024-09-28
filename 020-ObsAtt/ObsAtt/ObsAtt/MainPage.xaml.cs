namespace ObsAtt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void txt_Loaded(object sender, EventArgs e)
        {
            txt.Text = Globale.AbbsMethod();
        }
    }

}
