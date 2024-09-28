using System;
using System.Linq;
using System.Reflection;

namespace DynaObjectsMethods
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        static string GetParameters(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Type? MyTypeClass = typeof(MyClass);
            txt_FullName.Text = MyTypeClass.FullName;
            txt_TypeName.Text = MyTypeClass.Name;

            foreach(PropertyInfo propertie in MyTypeClass.GetProperties())
            {
                txt_Properties.Text += $"Propertie Name : {propertie.Name}, Type : {propertie.PropertyType}\n";
            }

            foreach (MethodInfo Method in MyTypeClass.GetMethods())
            {
                txt_Methods.Text += $"{Method.ReturnType} {Method.Name}({GetParameters(Method.GetParameters())})\n";
            }
            object? myClassInstance = Activator.CreateInstance(MyTypeClass);
            MyTypeClass.GetProperty("Property1").SetValue(myClassInstance, 10);
            txt_Property1.Text = ((int)MyTypeClass.GetProperty("Property1").GetValue(myClassInstance)).ToString();
            txt_InvokeMethod1.Text = (string)MyTypeClass.GetMethod("Methode1").Invoke(myClassInstance, null);
            object[] parameters = { 30, "Alae Azzaoui" };
            txt_InvokeMethod2.Text = (string)MyTypeClass.GetMethod("Methode2").Invoke(myClassInstance, parameters);
        }
    }

}
