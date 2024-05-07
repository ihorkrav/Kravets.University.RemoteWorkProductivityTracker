using System.ComponentModel.DataAnnotations;

namespace RemoteWorkProductivityTracker.Models.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required, EmailAddress]
        private string Email { get; set; }
        private string? Password { get; set; }

    }
}
