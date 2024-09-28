namespace LambdaExpression
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        delegate decimal Oparation(decimal value1, decimal value2);

        private void btn_Calc_Clicked(object sender, EventArgs e)
        {
            decimal value1, value2;
            if (!decimal.TryParse(txt_Num1.Text, out value1))
                return;
            if (!decimal.TryParse(txt_Num2.Text, out value2))
                return;
            Oparation Add = (V1, V2) => V1 + V2;
            Oparation Sub = (V1, V2) => V1 - V2;
            lbl_Add.Text = Add(value1, value2).ToString();
            lbl_Subtract.Text = Sub(value1, value2).ToString();
        }
    }

}
