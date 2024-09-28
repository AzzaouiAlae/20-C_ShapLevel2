namespace TypClas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Type t = typeof(string);
            txt_Name.Text = t.Name;
            txt_FullName.Text = t.FullName;
            txt_isClass.Text = t.IsClass.ToString();
        }
    }

}
