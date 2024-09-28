namespace GenericClasse
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            GenericBox<int> g1 = new GenericBox<int>(30);
            txt2.Text = g1.Value.ToString();

            GenericBox<string> g2 = new GenericBox<string>("Alae azzaoui");
            txt1.Text = g2.Value;
        }
    }
}
