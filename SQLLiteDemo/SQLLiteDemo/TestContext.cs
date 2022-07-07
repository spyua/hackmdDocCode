using SQLite.CodeFirst;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SQLLiteDemo
{

    [Table("TestTable")]
    public class TestTable
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Content { get; set; }
    }


    public class TestContext : DbContext
    {
        private static readonly bool[] s_migrated = { false };

        public DbSet<TestTable> TestTables { get; set; }

        public TestContext() : base("LocalDBConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (!s_migrated[0])
            {
                lock (s_migrated)
                {
                    if (!s_migrated[0])
                    {
                        var initializer = new SqliteDropCreateDatabaseWhenModelChanges<TestContext>(modelBuilder);
                        Database.SetInitializer(initializer);

                        s_migrated[0] = true;
                    }
                }
            }
        }
    }
}
