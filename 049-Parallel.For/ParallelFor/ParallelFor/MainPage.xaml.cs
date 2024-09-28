

namespace ParallelFor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int numOfIteration = vsl.Children.Count;
            Parallel.For(0, numOfIteration, (i) =>
            {
                if (vsl.Children[(int)i] is Label)
                {
                    Task.Run(() =>
                    {
                        for(int j = 0; j <= 15; j++)
                        {
                            MainThread.InvokeOnMainThreadAsync(() => ((Label)vsl.Children[(int)i]).Text = j.ToString() ) ;
                            Thread.Sleep(1000);
                        }
                    });
                }
            });
        }
    }

}
