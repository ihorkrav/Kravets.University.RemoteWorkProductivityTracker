namespace RemoteWorkProductivityTracker.Models.Data.Entities
{
    public class TrackerTask
    {
        public int Id { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private bool Compleate { get; set; }
        private List<User> Users { get; set; }
    }
}
