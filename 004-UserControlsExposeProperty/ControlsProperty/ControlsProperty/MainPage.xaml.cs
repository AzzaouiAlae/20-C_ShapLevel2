namespace ControlsProperty
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HorsListOfProducts_onBtnAddToCardCliked(string Name)
        {
            lbl.Text =   "You Clicked on " + Name;
        }
    }

}
