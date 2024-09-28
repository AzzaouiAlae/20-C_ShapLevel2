namespace TaskClass
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Task<int> result = Method1();

            lbl2.Text = "Name : Alae Azzaoui";

            int Age = await result;
            lbl1.Text = $"Age : {Age}";
        }
        async Task<int> Method1()
        {
            await Task.Delay(3000);

            return 30;
        }
    }

}
