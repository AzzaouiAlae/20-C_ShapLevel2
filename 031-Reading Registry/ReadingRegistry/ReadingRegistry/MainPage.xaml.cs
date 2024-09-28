using Microsoft.Win32;

namespace ReadingRegistry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Btn_Create_Clicked(object sender, EventArgs e)
        {
            string KeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\alaeSoftware";
            try
            {
                if (DeviceInfo.Current.Platform.ToString() == "WinUI")
                {
                    string str = Registry.GetValue(KeyPath, txt_ValueName.Text, null) as string;
                    if(str != null)
                    {
                        txt_ValueData.Text = str;
                        lbl_Message.Text = "Key is Found";
                    }
                    else
                        lbl_Message.Text = "Key not is Found";
                }

                else
                    return;
                
            }
            catch (Exception ex)
            {
                lbl_Message.Text = ex.Message;
            }
        }
    }

}
