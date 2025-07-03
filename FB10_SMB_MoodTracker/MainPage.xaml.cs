using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace FB10_SMB_MoodTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}