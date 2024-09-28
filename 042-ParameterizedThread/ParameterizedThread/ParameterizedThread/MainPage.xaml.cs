namespace ParameterizedThread
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Method1(lbl));
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                lbl.Text += "Btn - " + i;
                Thread.Sleep(200);
            }

        }

        void Method1(Label label)
        {
            for(int i = 0; i < 10; i++)
            {
                label.Text += "Method1 - " + i;
                Thread.Sleep(200);
            }
        }
    }

}
