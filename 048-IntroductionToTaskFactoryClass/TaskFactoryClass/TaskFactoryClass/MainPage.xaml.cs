using System.Threading.Tasks;

namespace TaskFactoryClass
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            token = cts.Token;

            taskFactory = new TaskFactory(
                token,
                TaskCreationOptions.AttachedToParent,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default);
        }

        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token;
        TaskFactory taskFactory;

        private void Btn_Start_Clicked(object sender, EventArgs e)
        {
            Task t1 = taskFactory.StartNew(() =>
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (token.IsCancellationRequested)
                        break;

                    MainThread.InvokeOnMainThreadAsync(() => lbl1.Text = i.ToString());
                    Thread.Sleep(1000);
                }
            });
        }

        private void Btn_Pause_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Btn_Stop_Clicked(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }

}
