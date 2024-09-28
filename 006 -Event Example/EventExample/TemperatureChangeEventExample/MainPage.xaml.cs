namespace TemperatureChangeEventExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        clsThermostat t = new clsThermostat();
        private void btn_Ok_Clicked(object sender, EventArgs e)
        {
            decimal.TryParse(txt_Temperature.Text, out decimal Temperature);
            t.Temperature = Temperature;
        }
        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            cDisplay.Subscribe(t);
            airConditioner.Subscribe(t);
        }
    }

}
