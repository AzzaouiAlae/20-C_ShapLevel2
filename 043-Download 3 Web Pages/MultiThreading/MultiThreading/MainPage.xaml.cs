namespace MultiThreading
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            webPage_ProgAdvices = pg_ProgAdvices;
            webPage_Amazone = pg_Amazone;
            webPage_CNN = pg_CNN;
        }
        static public WebPage webPage_ProgAdvices = new WebPage();
        static public WebPage webPage_Amazone = new WebPage();
        static public WebPage webPage_CNN = new WebPage();
    }

}
