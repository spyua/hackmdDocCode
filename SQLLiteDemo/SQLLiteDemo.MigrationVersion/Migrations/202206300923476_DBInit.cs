namespace SQLLiteDemo.MigrationVersion
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestTable",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestTable");
        }
    }
}
