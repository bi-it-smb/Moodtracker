using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace FB10_SMB_MoodTracker;

public partial class RatingPageViewModel : ObservableObject
{
    public Course Course { get; }

    [ObservableProperty]
    int? rating;

    [ObservableProperty]
    string comment;

    public RatingPageViewModel(Course course)
    {
        Course = course;
        Rating = course.Rating;
        Comment = course.Comment;
    }

    [RelayCommand]
    public async Task SaveRatingAsync()
    {
        if (Rating == null)
        {
            await Shell.Current.DisplayAlert("Fehler", "Bitte geben Sie eine Bewertung ab.", "OK");
            return;
        }

        Course.Rating = Rating;
        Course.Comment = Comment;

        var file = Path.Combine(FileSystem.AppDataDirectory, "courses.json");
        if (File.Exists(file))
        {
            var json = await File.ReadAllTextAsync(file);
            var courseData = JsonSerializer.Deserialize<CourseData>(json);
            var courseInList = courseData?.Courses?.Find(c => c.Name == Course.Name);
            if (courseInList != null)
            {
                courseInList.Rating = Rating;
                courseInList.Comment = Comment;
                var newJson = JsonSerializer.Serialize(courseData, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(file, newJson);
            }
        }
    }
}
