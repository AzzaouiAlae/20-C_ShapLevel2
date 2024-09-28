namespace OperatorOverloading
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        clsPoint P1 = new clsPoint(0, 0);

        clsPoint P2 = new clsPoint(0, 0);
        private void btn_Calc_Clicked(object sender, EventArgs e)
        {
            switch(pik_Operation.SelectedItem.ToString())
            {
                case "+":
                    txt_Result.Text = (P1 + P2).ToString();
                    break;
                case "-":
                    txt_Result.Text = (P1 - P2).ToString();
                    break;
                case "*":
                    txt_Result.Text = (P1 * P2).ToString();
                    break;
                case "/":
                    txt_Result.Text = (P1 / P2).ToString();
                    break;
            }
        }
        private void txt_x1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;

            CheckNumber(ref value, (Entry)sender, e);

            P1.x = value;
        }
        private void txt_y1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;

            CheckNumber(ref value, (Entry)sender, e);

            P1.y = value;
        }
        private void txt_x2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;

            CheckNumber(ref value, (Entry)sender, e);

            P2.x = value;
        }
        private void txt_y2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = 0;

            CheckNumber(ref value, (Entry)sender, e);

            P2.y = value;
        }
        void CheckNumber(ref int value, Entry entry, TextChangedEventArgs e)
        {
            if (entry.Text == null || entry.Text == "")
                return;

            if (!int.TryParse(entry.Text, out value))
                entry.Text = e.OldTextValue;
        }
    }

}
