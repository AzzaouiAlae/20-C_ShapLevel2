namespace CustomAttribu
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MyAbcAttribute : Attribute
    {
        public string Description { get; }


        public MyAbcAttribute(string description)
        {
            Description = description;
        }
    }
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            MyClass.MyMethod();
        }



        [MyAbc("This is a class attribute")]
        class MyClass
        {
            [MyAbc("This is a method attribute")]
            static public void MyMethod()
            {
                // Method implementation
            }
        }

    }

}
