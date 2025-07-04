using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace FB10_SMB_MoodTracker;

public partial class RatingPageViewModel : ObservableObject
{
    private readonly RatingRepository repository = new RatingRepository();

    public Course Course { get; }

    [ObservableProperty]
    int? rating;

    [ObservableProperty]
    string comment;

    public RatingPageViewModel(Course course)
    {
        Course = course;
        LoadRating();
    }

    // Gets the saved rating from the repository
    private async void LoadRating()
    {
        var saved = await repository.GetRatingAsync(Course.Name);
        if (saved != null)
        {
            Rating = saved.Rating;
            Comment = saved.Comment;
        }
        else
        {
            Rating = null;
            Comment = string.Empty;
        }
    }

    // Saves the rating and comment. It won't save if no rating was selected.
    [RelayCommand]
    public async Task SaveRatingAsync()
    {
        if (Rating == null)
        {
            await Application.Current.MainPage.DisplayAlert("Fehler", "Bitte wählen Sie eine Bewertung (1-5 Sterne) aus.", "OK");
            return;
        }

        var entry = new RatingEntry
        {
            CourseName = Course.Name,
            Rating = Rating,
            Comment = Comment
        };

        await repository.UpsertRatingAsync(entry);

        await Application.Current.MainPage.DisplayAlert("Erfolg", "Bewertung wurde gespeichert.", "OK");
    }
}
