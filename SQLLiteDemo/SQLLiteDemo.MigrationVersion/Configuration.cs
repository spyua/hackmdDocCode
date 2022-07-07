using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace SQLLiteDemo.MigrationVersion
{
    public class Configuration : DbMigrationsConfiguration<TestContext>
    {
        public Configuration()
        {
            // 需自行設定
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            // Gen SQL Lite Migration
            this.SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
        protected override void Seed(TestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }

    }
}
