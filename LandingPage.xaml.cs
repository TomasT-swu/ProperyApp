using CourseProject.ViewModel;
using Microsoft.Maui.Controls;
using System;

namespace CourseProject.View
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            this.BindingContext = new LandingViewModel();
            (SectionList.Children[index: 0] as RadioButton).IsChecked = true;
        }

        private async void OnImageTapped(object sender, EventArgs e)
        {
            string youtubeLink = "https://vlipsy.com/vlip/hElgqOJl";
            await Launcher.Default.OpenAsync(youtubeLink);
        }
    }
}
