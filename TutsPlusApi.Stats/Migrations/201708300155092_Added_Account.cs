namespace TutsPlusApi.Stats.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Account_Id", c => c.Int());
            CreateIndex("dbo.Users", "Account_Id");
            AddForeignKey("dbo.Users", "Account_Id", "dbo.Accounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Users", new[] { "Account_Id" });
            DropColumn("dbo.Users", "Account_Id");
            DropTable("dbo.Accounts");
        }
    }
}
