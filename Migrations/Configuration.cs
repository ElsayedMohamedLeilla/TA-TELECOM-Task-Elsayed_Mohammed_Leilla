namespace Elsayed_Mohammed_Leilla.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationDbContext>
    {
        private readonly bool _pendingMigrations;
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = false;
            //ContextKey = "Elsayed_Mohammed_Leilla.Models.ApplicationDbContext";


        }

        protected override void Seed(Models.ApplicationDbContext context)
        {

            //var mobileNumbers = new List<MobileNumber>
            //{
            //    new MobileNumber { Code = 1,   Number = ("010" + DateTime.Now.Ticks + DateTime.Now.Year),
            //        Sent = false },
            //    new MobileNumber { Code = 2,   Number = ("010" + DateTime.Now.Ticks + DateTime.Now.Year),
            //        Sent = false },
            //};
            //mobileNumbers.ForEach(s => context.MobileNumbers.AddOrUpdate(p => p.Code, s));
            //context.SaveChanges();
        }
    }
}
