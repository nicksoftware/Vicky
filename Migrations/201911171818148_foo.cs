namespace Vicky.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String());
        }
    }
}
