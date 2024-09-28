namespace ParallelForEach
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn_Start_Clicked(object sender, EventArgs e)
        {
            Parallel.ForEach(vsl.Children, (view) =>
            {
                if(view is Label)
                {
                    Task.Run(() =>
                    {
                        for(int i = 0;i <=10;i++)
                        {
                            MainThread.BeginInvokeOnMainThread(() => { ((Label)view).Text = i.ToString(); });
                            Thread.Sleep(500);
                        }
                    });
                }
            });
        }
    }

}
