using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SimpleMVCPoll.Models;

namespace SimpleMVCPoll.DataAccessLayer
{
    public class SimplePollContext: DbContext
    {
        public SimplePollContext():base("SimplePollContext")
        {

        }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}