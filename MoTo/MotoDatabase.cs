namespace MoTo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Data;

    public partial class MoToDatabase : DbContext
    {
        public MoToDatabase()
            : base("name=MotoDatabse")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Table1> Table1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        SqlConnection connection = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\MotoDatabase.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
    }
}
