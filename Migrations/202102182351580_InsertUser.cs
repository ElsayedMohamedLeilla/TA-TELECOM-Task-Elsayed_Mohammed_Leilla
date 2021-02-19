namespace Elsayed_Mohammed_Leilla.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InsertUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AspNetUsers(id,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName) VALUES " +
                "('0dac3b18-2772-4851-a7a3-3cf01c10acfd','elsayed_leilla@gmail.com',0,'ABBlh3imud2TaLUGONWc67TINNTSAeWE+pWHSchMurpLKG7to+wO/I/p886CQBajbA==','bbb2dd30-0e89-4ff0-8f32-1357cd2fb329',null,0,0,null,1,0,'Elsayed_Leilla')");
        }

        public override void Down()
        {
        }
    }
}
