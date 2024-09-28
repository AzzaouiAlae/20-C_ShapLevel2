using System;
using System.Reflection;

namespace ReflecCustomAttrib
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Type type = typeof(MyClass);

            object[] classAttr = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach(MyCustomAttribute attribute in classAttr)
            {
                txt_ClasAtt.Text += $"{attribute.Description}";
            }

            MethodInfo? method = type.GetMethod("MyMethod");
            object[] MethodAttr = method.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach (MyCustomAttribute m in MethodAttr)
            {
               txt_MethodAtt.Text += $"{m.Description}";
            }
        }
    }

}
