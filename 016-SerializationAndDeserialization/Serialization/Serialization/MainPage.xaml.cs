using System.Xml.Serialization;

namespace Serialization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Person.Load += LoadDate;
        }
        Person person = new Person();
        void LoadDate(Person p)
        {
            txt_Name.Text = p.Name;
            txt_Age.Text = p.Age.ToString();
        }
        private void btn_Save_Clicked(object sender, EventArgs e)
        {
            person.Name = txt_Name.Text;
            sbyte.TryParse(txt_Age.Text, out sbyte Age);
            person.Age = Age;
            person.SaveToFile();
        }

        private void btn_Open_Clicked(object sender, EventArgs e)
        {
            person.LoadData();
        }
    }
}
