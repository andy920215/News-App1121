using News_App.Pages;

namespace News_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewsHomePage());
        }
    }
}