using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SQLLiteDemo.MigrationVersion
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
        public DbSet<TestTable> TestTables { get; set; }

        public TestContext() : base("LocalDBConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
