namespace MVCFrameworkCustomerMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b086858d-4bdd-4682-9466-bcd52fd9db55', N'admin@gmail.com', 0, N'ABGVB/pVUlZzafDW7rMFbw0jDOlgEfSJucPwZJSctCOMMZ90iwa/nL2EFRb10EKEwA==', N'3f004781-60d6-4c22-b8f3-feeeb9422663', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc557513-f4b5-411a-94e7-130e2034d0a7', N'guest@gmail.com', 0, N'AAn3iwZImeNK5asGrfPFVo5WiIyMh5pVJXqZ8zDP1LCbEJF7yjSgrpgqaE3Yk4jNwA==', N'bed41666-d7fa-41e3-b354-6641828bfbb7', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3f43d97c-2123-4f7c-8eee-ce7ff95f4fde', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b086858d-4bdd-4682-9466-bcd52fd9db55', N'3f43d97c-2123-4f7c-8eee-ce7ff95f4fde')

");
        }
        
        public override void Down()
        {
        }
    }
}
