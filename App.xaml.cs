using CourseProject.View;

namespace CourseProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(root: new LandingPage());
        }
    }
}
