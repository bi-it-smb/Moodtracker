using CommunityToolkit.Mvvm.ComponentModel;

namespace FB10_SMB_MoodTracker
{
    public partial class DetailViewModel : ObservableObject
    {
        public Course Course { get; }

        public DetailViewModel(Course course)
        {
            Course = course;
        }
    }
}
