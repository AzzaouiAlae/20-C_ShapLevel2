namespace AttribForValid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string msg = "";
        private void btn_Clicked(object sender, EventArgs e)
        {
            ClsPerson p = new ClsPerson(Age, txt_Name.Text);
            
            if(ClsValidation.Validation(p, ref msg))
                lbl_Result.Text = "Person is Valide";
            
            else
                lbl_Result.Text = msg;
        }
        byte Age = 0;
        private void txt_Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_Age.Text == "" || txt_Age.Text is null)
            {
                Age = 0;
                return;
            }

            if (!byte.TryParse(txt_Age.Text, out Age))
                txt_Age.Text = e.OldTextValue;
        }
    }

}
