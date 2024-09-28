namespace SendDataBack
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
            SelectPersonPage selectPersonPage = new SelectPersonPage();
            selectPersonPage.PersonID_Back += SelectPersonPage_PersonID_Back;

            Navigation.PushAsync(selectPersonPage);

        }

        private void SelectPersonPage_PersonID_Back(int PersonID)
        {
            _PersonID = PersonID;
            txt.Text = PersonID.ToString();
        }
    }

}
