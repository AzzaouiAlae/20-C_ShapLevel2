using System.Diagnostics;
using System.Text;

namespace SstringBuilderr
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int iteration = 100000;
            Stopwatch stopwatch = Stopwatch.StartNew();
            TestNormalString(iteration);
            stopwatch.Stop();

            txt_NormalString.Text = stopwatch.ElapsedMilliseconds.ToString();

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            TestStringBilder(iteration);
            stopwatch2.Stop();
            txt_StringBilder.Text = stopwatch2.ElapsedMilliseconds.ToString();
        }

        void TestNormalString(int iteration)
        {
            string test = "";
            for(int i = 0; i < iteration; i++)
            {
                test += "a";
            }
        }

        void TestStringBilder(int iteration)
        {
            StringBuilder test = new StringBuilder();
            for (int i = 0; i < iteration; i++)
            {
                test.Append("a");
            }
        }
    }

}
