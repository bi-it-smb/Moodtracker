using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace FB10_SMB_MoodTracker;

public partial class MainPageViewModel
{
    public ObservableCollection<Course> Courses { get; set; } = new();

    private const string FileName = "courses.json";

    public MainPageViewModel()
    {
        _ = InitializeAsync();
    }

    private async Task InitializeAsync()
    {
        var file = Path.Combine(FileSystem.AppDataDirectory, FileName);

        if (!File.Exists(file))
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("courses.json");
            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();
            await File.WriteAllTextAsync(file, json);
        }

        await ReadFile(file);
    }

    [RelayCommand]
    async Task NavigateToDetail(Course course)
    {
        var vm = new DetailViewModel(course);
        await Shell.Current.Navigation.PushAsync(new DetailPage(vm));
    }

    [RelayCommand]
    async Task NavigateToRating(Course course)
    {
        var vm = new RatingPageViewModel(course);
        await Shell.Current.Navigation.PushAsync(new RatingPage(vm));
    }
    private async Task ReadFile(string file)
    {
        if (File.Exists(file))
        {
            var json = await File.ReadAllTextAsync(file);
            var courseData = JsonSerializer.Deserialize<CourseData>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
            Courses.Clear();
            if (courseData?.Courses != null)
            {
                foreach (var course in courseData.Courses)
                    Courses.Add(course);
            }
        }
    }
}