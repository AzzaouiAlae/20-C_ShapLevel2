namespace SendDataBak
{
    public partial class MainPage : ContentPage
    {
        int _PersonID;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSelectPerson_Clicked(object sender, EventArgs e)
        {
            SelectPersonPage sp = new SelectPersonPage();
            sp.PersonID_Back += Sp_PersonID_Back;
            Navigation.PushAsync(sp);
        }

        private void Sp_PersonID_Back(int PersonID)
        {
            _PersonID = PersonID;
            txt.Text = PersonID.ToString();
        }
    }

}
