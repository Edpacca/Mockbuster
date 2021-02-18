namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a2b8331-cf61-42b5-ba7c-e51dd2c16c01', N'guest@mockbuster.com', 0, N'AEIrsggazV7IbGQXGOvMjTzFpFuVsakp69UKfDP7BL/Q98o9QlrzxxT05BQZuGqfXw==', N'bdee6257-0478-47f6-b878-e5e9e61f8595', NULL, 0, 0, NULL, 1, 0, N'guest@mockbuster.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1b7244ea-61a4-42ce-839c-590212ce82c0', N'admin@mockbuster.com', 0, N'AOgKDwUiObxW0LmlPJTcYxEa9JoOGl5Ooop4GrhVSME+8fVR6UxpqumXSEb/1yjryA==', N'35cb158f-4265-4fbb-9ed1-c58fea3cb48a', NULL, 0, 0, NULL, 1, 0, N'admin@mockbuster.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5682a5be-edf1-49af-b30f-e5ecb904fd7d', N'mrmockbuster@mockbuster.com', 0, N'AMdyP285K/xFjHQAESWUAkykRPX+N0qItxfeBmvxYSjSOrY/qvMrx3x5zC17GWQzTA==', N'ed0064bd-e8f2-4420-9b63-1d479a1b70fb', NULL, 0, 0, NULL, 1, 0, N'mrmockbuster@mockbuster.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'35c2a109-66d4-4dc8-ad86-fa489ee35288', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1b7244ea-61a4-42ce-839c-590212ce82c0', N'35c2a109-66d4-4dc8-ad86-fa489ee35288')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
