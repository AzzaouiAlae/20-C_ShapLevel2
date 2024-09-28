namespace JsonSerialize
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ClsPerson.Load += LoadPersonToForm;
        }
        byte Age;
        private void txt_Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_Age.Text == "")
            {
                Age = 0;
                return;
            }

            if (!byte.TryParse(txt_Age.Text, out Age))
                txt_Age.Text = e.OldTextValue;
        }
        void LoadPersonToForm(ClsPerson person)
        {
            txt_Name.Text = person.Name;
            txt_Age.Text = person.Age.ToString();
        }
        private void btn_Save_Clicked(object sender, EventArgs e)
        {
            ClsPerson p = new ClsPerson();
            p.Name = txt_Name.Text;
            p.Age = Age;
            p.SaveDataFromXml("C:\\Users\\Alae\\Desktop\\Nouveau dossier (3)\\p.json");
        }
        private void btn_Load_Clicked(object sender, EventArgs e)
        {
            ClsPerson.LoadData("C:\\Users\\Alae\\Desktop\\Nouveau dossier (3)\\p.json");
        }
    }

}
