using System.Security.Cryptography;
using System.Text;

namespace HashingExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = ComputeHash(txt_Password.Text);

            Navigation.PushAsync(new LoginPage(username, password));
        }
        static public string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }

}
