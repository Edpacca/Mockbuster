namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'6e90d2ca-fd66-468e-8d37-7648eb2b8ca7', N'admin1@mockbuster.com', 0, N'AAthJ8y2sd+vRO/zFbolHVai+FGY847Zvy7fgSHQ3los+3G5EgpWMtLMI4oWAWdBSw==', N'facd5c0c-0bec-4d50-824c-fa1bd7fcffb0', N'01923923', 0, 0, NULL, 1, 0, N'admin1@mockbuster.com', N'2395481')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6e90d2ca-fd66-468e-8d37-7648eb2b8ca7', N'35c2a109-66d4-4dc8-ad86-fa489ee35288')");
        }
        
        public override void Down()
        {

        }
    }
}
