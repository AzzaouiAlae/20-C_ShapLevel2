
using System.IO;
using F = System.IO.StreamReader;

namespace UsingStatement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            using (var sr = new F("C:\\Users\\Alae\\Desktop\\mustapha\\T.39375R Bloc . Lot\\A.txt"))
            {
                txt.Text = sr.ReadToEnd();
            }
        }
    }

}
