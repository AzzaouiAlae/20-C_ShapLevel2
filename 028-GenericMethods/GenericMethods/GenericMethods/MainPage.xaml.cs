using System;

namespace GenericMethods
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        static void Swap<T>(ref T first,ref T Second)
        {
            T temp = first;
            first = Second;
            Second = temp;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Swap(ref txt3, ref txt1);
        }
    }

}
