namespace ParallelInvoke
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn_Start_Clicked(object sender, EventArgs e)
        {
            Task.Run(() => Invoke_Count());            
        }
        void Invoke_Count()
        {
            Parallel.Invoke(lbl1_Count, lbl2_Count, lbl3_Count);
            MainThread.InvokeOnMainThreadAsync(() => { lbl4.Text = "Complete"; });
        }
        void lbl1_Count()
        {
            for(int i = 0; i <= 10; i++)
            {
                MainThread.InvokeOnMainThreadAsync(() => { lbl1.Text =  i.ToString(); });
                Thread.Sleep(1000);
            }
        }
        void lbl2_Count()
        {
            for (int i = 0; i <= 10; i++)
            {
                MainThread.InvokeOnMainThreadAsync(() => { lbl2.Text = i.ToString(); });
                Thread.Sleep(1000);
            }
        }
        void lbl3_Count()
        {
            for (int i = 0; i <= 10; i++)
            {
                MainThread.InvokeOnMainThreadAsync(() => { lbl3.Text = i.ToString(); });
                Thread.Sleep(1000);
            }
        }
    }
}
