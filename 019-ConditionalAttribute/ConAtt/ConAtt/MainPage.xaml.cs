//#define Test

using System.Diagnostics;

namespace ConAtt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NormalFunc();
            DebugFunc();
            TestFunc();
        }
        public void NormalFunc()
        {
            txt_NormalFunc.Text = "Normal Func is run";
        }
        [Conditional("DEBUG")]
        public void DebugFunc()
        {
            txt_DebugFunc.Text = "Debug Func is run";
        }
        [Conditional("Test")]
        public void TestFunc()
        {
            txt_TestFunc.Text = "Test Func is run";
        }
    }

}
