namespace MAUISample;

public partial class App : Application
{
	public App()
	{
        try
        {
            InitializeComponent();

            MainPage = new FlyoutViewPage();// new AppShell();

            var xyz = MAUISample.AppResources.LocalResources.HelloVikram;
            Console.WriteLine("Test text " + xyz);
        }
        catch (Exception ex)
        {
            Console.WriteLine("App Exception: " + ex.Message + " Strace: " + ex.StackTrace);
        }
        
    }
}

