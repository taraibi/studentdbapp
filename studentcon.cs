using System.Data.Entity;

namespace StudentDatabaseApp
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolContext() : base("name=SchoolDB")
        {
        }
    }
}