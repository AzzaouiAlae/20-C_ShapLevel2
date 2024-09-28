namespace FuncDelegate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        

        decimal SquareOfNum(decimal num)
        {
            return num * num;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            decimal Num;
            if (!decimal.TryParse(txt_Num.Text, out Num))
                return;

            Globale.Square = SquareOfNum;
            lbl.Text = Globale.Square(Num).ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
    }

}
