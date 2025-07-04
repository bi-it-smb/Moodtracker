using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FB10_SMB_MoodTracker;

public class RatingRepository
{
    private readonly string filePath = Path.Combine(FileSystem.AppDataDirectory, "ratings.json");

    public async Task<List<RatingEntry>> LoadAllAsync()
    {
        if (!File.Exists(filePath))
        {
            return new List<RatingEntry>();
        }

        var json = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<List<RatingEntry>>(json) ?? new List<RatingEntry>();
    }

    // Saves the given list of ratings to the "ratings.json" file
    private async Task SaveAllAsync(List<RatingEntry> ratings)
    {
        var json = JsonSerializer.Serialize(ratings, new JsonSerializerOptions { WriteIndented = true });
        await File.WriteAllTextAsync(filePath, json);
    }

    // Inserts a new rating or updates an existing rating for a course
    public async Task UpsertRatingAsync(RatingEntry entry)
    {
        var ratings = await LoadAllAsync();

        var existing = ratings.FirstOrDefault(r => r.CourseName == entry.CourseName);
        if (existing != null)
        {
            existing.Rating = entry.Rating;
            existing.Comment = entry.Comment;
        }
        else
        {
            ratings.Add(entry);
        }

        await SaveAllAsync(ratings);
    }

    // Retrieves the rating for a specific course, if it exists
    public async Task<RatingEntry?> GetRatingAsync(string courseName)
    {
        var ratings = await LoadAllAsync();
        return ratings.FirstOrDefault(r => r.CourseName == courseName);
    }
}
