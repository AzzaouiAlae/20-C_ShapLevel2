namespace TaskClassWithEvent
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public delegate void CallBackEventHandler(object sender, PersonEventArgs e);

        public event CallBackEventHandler CallBack;

        private void btn_Clicked(object sender, EventArgs e)
        {
            CallBack += SetNameAsync;

            Task t = Count();

            Task t2 = GetNameAsync();            
        }
        async Task GetNameAsync()
        {
            await Task.Delay(3000);

            PersonEventArgs p = new("Alae Azzaoui", 30);
            SetNameAsync(null, p);
        }
        async Task Count()
        {
            for(byte i = 0; i <= 10; i++ )
            {
                await Task.Delay(1000);
                lbl_Counter.Text = (i).ToString();
            }            
        }
        void SetNameAsync(object? sender, PersonEventArgs e)
        {
            lbl_Name.Text = e.Name;
            lbl_Age.Text = e.Age.ToString();
        }
    }
}
