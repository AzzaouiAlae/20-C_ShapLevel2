namespace PredicateDelegate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState) =>
            new (new MainPage())
            {
                Width = 320,
                Height = 650,
            };
    }
}
