using System.Security.Cryptography;
using System.Text;

namespace SymmetricEncryption
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string key = "1234567890123456";
        private void btn_Encrypt_Clicked(object sender, EventArgs e)
        {
            txt_Encrypted.Text = Encrypt(txt_info.Text, key);
        }
        static public string Encrypt(string Text, string key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = new byte[aes.BlockSize / 8];

                ICryptoTransform Encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, Encryptor, CryptoStreamMode.Write))
                    using(var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(Text);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        static public string Decrypt(string Text, string key)
        {
            using(Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = new byte[aes.BlockSize / 8];

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var msDecryptor = new System.IO.MemoryStream(Convert.FromBase64String(Text)))
                using (var csDecryptor = new CryptoStream(msDecryptor, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new  System.IO.StreamReader(csDecryptor))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
        private void btn_Decrypte_Clicked(object sender, EventArgs e)
        {
            txt_DecryptedInfo.Text = Decrypt(txt_Encrypted.Text, key);
        }
    }
}
