namespace SpecialComm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            txt.Text = MyClass1.Add(10, 30).ToString();
        }
    }

}
