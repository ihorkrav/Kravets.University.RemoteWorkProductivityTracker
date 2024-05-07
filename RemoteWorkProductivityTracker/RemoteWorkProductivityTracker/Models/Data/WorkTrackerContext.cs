using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using RemoteWorkProductivityTracker.Models.Data.Entities;

namespace RemoteWorkProductivityTracker.Models.Data
{
    public class WorkTrackerContext : IdentityDbContext
    {
        public WorkTrackerContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users;
        DbSet<TrackerTask> Tasks;
    }
}
