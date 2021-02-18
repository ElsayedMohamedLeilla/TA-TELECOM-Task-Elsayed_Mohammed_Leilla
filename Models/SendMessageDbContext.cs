using System.Data.Entity;

namespace Elsayed_Mohammed_Leilla.Models
{
    public class SendMessageDbContext : DbContext
    {


        public SendMessageDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<MobileNumber> MobileNumbers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SendMessageDbContext, Elsayed_Mohammed_Leilla.Migrations.Configuration>());
        }
    }

}