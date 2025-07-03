public class Feedback
{
    public bool Enabled { get; set; }
    public string Type { get; set; }
    public string Hint { get; set; }
}

public class Course
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Location { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string Age { get; set; }
    public string Materials { get; set; }
    public Feedback Feedback { get; set; }
    public int? Rating { get; set; }
    public string RatingTimestamp { get; set; }
    public string Comment { get; set; }
}

public class CourseData
{
    public List<Course> Courses { get; set; }
}
