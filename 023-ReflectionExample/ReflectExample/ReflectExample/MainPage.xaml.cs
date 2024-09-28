using System;
using System.Linq;
using System.Reflection;

namespace ReflectExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Assembly msCorLib = typeof(string).Assembly;

            Type? strType = msCorLib.GetType("System.String");

            if(strType != null )
            {
                txt.Text = "Methods of the System.String class:\n";

                var stringMethds = strType.GetMethods(BindingFlags.Public | BindingFlags.Instance).OrderBy(Method => Method.Name);

                foreach(MethodInfo mi in stringMethds)
                {
                    txt.Text += $"\t{mi.ReturnType} {mi.Name} ({GetParameterList(mi.GetParameters())})\n";
                }
            }
        }

        string GetParameterList(ParameterInfo[] parameters)
        {
            return string.Join(", ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
    }

}
