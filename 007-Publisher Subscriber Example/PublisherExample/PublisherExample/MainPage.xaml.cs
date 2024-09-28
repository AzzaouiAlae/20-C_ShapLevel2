namespace PublisherExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            cEmail.Subscribe(cPublisher);
        }
    }

}
