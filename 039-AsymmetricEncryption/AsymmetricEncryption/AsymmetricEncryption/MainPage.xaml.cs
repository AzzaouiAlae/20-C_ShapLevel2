using System.Security.Cryptography;
using System.Text;

namespace AsymmetricEncryption
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string PrivateKey = "";

        string PublicKey = "";
        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new())
                {
                    PublicKey = rsa.ToXmlString(false);

                    PrivateKey = rsa.ToXmlString(true);

                    txt_PublicKey.Text = PublicKey;
                    txt_PrivateKey.Text = PrivateKey;
                }
            }
            catch 
            { 

            }            
        }
        static public string Encrypt(string Text, string PublicKey)
        {
            try
            {
                using (RSACryptoServiceProvider RSA = new())
                {
                    RSA.FromXmlString(PublicKey);

                    byte[] encryptedData = RSA.Encrypt(Encoding.UTF8.GetBytes(Text), false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch
            {

            }
            return "";
        }
        static public string Decrypt(string Text, string PrivateKey)
        {
            try
            {
                using(RSACryptoServiceProvider RSA = new())
                {
                    RSA.FromXmlString(PrivateKey);
                    byte[] encryptedData = Convert.FromBase64String(Text);
                    byte[] decryptedData = RSA.Decrypt(encryptedData, false);

                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
            catch
            {

            }
            return "";
        }
        private void btn_Encrypt_Clicked(object sender, EventArgs e)
        {
            txt_EncryptedMessage.Text = Encrypt(txt_OriginalText.Text, PublicKey);
        }
        private void btn_Decrypt_Clicked(object sender, EventArgs e)
        {
            txt_DecryptedMessage.Text = Decrypt(txt_EncryptedMessage.Text, PrivateKey);
        }
    }
}
