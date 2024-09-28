namespace CalculatorDelegation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (((Entry)sender).Text == "")
                return;

            if (!decimal.TryParse(((Entry)sender).Text, out decimal Num))
                ((Entry)sender).Text = e.OldTextValue;
        }
        private void btn_Addition_Clicked(object sender, EventArgs e)
        {
            decimal Num;
            if (!decimal.TryParse(txt_Addition.Text, out Num))
                return;

            Calc.Addition(Num);
            txt_Addition.Text = "";
            txt_Addition.Focus();
        }
        void SetResult(decimal Reslut)
        {
            lbl_Result.Text = "Reslut : " + Reslut;
        }
        void SetResult2(decimal Reslut)
        {
            lbl_Result2.Text = "Reslut : " + Reslut;
        }
        ClsCalculator Calc;
        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            Calc = new ClsCalculator(SetResult);
            Calc.resultAction += SetResult2;
        }

        private void btn_Result_Clicked(object sender, EventArgs e)
        {
            Calc.Result();
        }

        private void btn_Subtraction_Clicked(object sender, EventArgs e)
        {
            decimal Num;
            if (!decimal.TryParse(txt_Subtraction.Text, out Num))
                return;

            Calc.Subtraction(Num);
            txt_Subtraction.Text = "";
            txt_Subtraction.Focus();
        }

        private void btn_Multiplication_Clicked(object sender, EventArgs e)
        {
            decimal Num;
            if (!decimal.TryParse(txt_Multiplication.Text, out Num))
                return;

            Calc.Multiplication(Num);
            txt_Multiplication.Text = "";
            txt_Multiplication.Focus();
        }

        private void btn_Division_Clicked(object sender, EventArgs e)
        {
            decimal Num;
            if (!decimal.TryParse(txt_Division.Text, out Num))
                return;

            Calc.Division(Num);
            txt_Division.Text = "";
            txt_Division.Focus();
        }
    }

}
