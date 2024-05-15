namespace RemoteWorkProductivityTracker.Areas.Identity.Data
{
    public class Sections
    {
        public int Id { get; set; }
        private int UserId { get; set; }
        private string Title { get; set; }
        private List<TrackerTask> Tasks { get; set; }
    }
}
