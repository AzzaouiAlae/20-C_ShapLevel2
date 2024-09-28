namespace Synchronization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int SherdCounter = 0;

        object lockObj = new object();
        private void Button_Clicked(object sender, EventArgs e)
        {
            Action a = () => lbl1.Text = SherdCounter.ToString();
            Thread t1 = new(() => StratThred(a));
            t1.Start();
            t1.Join();

            Action a2 = () => lbl2.Text = SherdCounter.ToString();
            t1 = new(() => StratThred(a2));
            t1.Start();
        }        
        void StratThred(Action action)
        {
            lock (lockObj)
            {
                Start(action);
            }            
        }
        async void Start(Action action)
        {
            for (int i = 0; i < 10000; i++)
            {
                SherdCounter++;
                await MainThread.InvokeOnMainThreadAsync(() => action());
            }
        }
    }

}
