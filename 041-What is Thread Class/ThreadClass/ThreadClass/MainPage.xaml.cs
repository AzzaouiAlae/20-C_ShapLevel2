using System.Threading;

namespace ThreadClass
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string test = "";
        void Method1()
        {
            for(int i = 1;i <= 10; i++)
            {
                test += $"Method1 = i {i}\n";
                Thread.Sleep(200);
            }            
        }
        void Method2()
        {
            for (int i = 1; i <= 10; i++)
            {
                test += $"Method2 = i {i}\n";
                Thread.Sleep(200);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Thread T = new Thread(Method1);
            T.Start();
            //T.Join();
            Thread T2 = new Thread(Method2);
            T2.Start();
            //T2.Join();
            for (int i = 1; i <= 10; i++)
            {
                test += $"Button = i {i}\n";
                lbl.Text += test;
                test = "";
                Thread.Sleep(200);
            }
        }
    }

}
