namespace FB10_SMB_MoodTracker;

public partial class RatingPage : ContentPage
{
    public RatingPage(RatingPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}