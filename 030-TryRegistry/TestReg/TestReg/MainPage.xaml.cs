using System;
using Microsoft.Win32;

namespace TestReg
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
                    Registry.SetValue(KeyPath, txt_ValueName.Text, txt_ValueData.Text);
                
                else
                    return;
                lbl_Message.Text = "Key is created successfully";
            }
            catch (Exception ex)
            { 
                lbl_Message.Text = ex.Message;
            }
        }
    }

}
