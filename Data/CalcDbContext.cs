using Microsoft.EntityFrameworkCore;

namespace Calculator.Data
{
    public class CalcDbContext : DbContext
    {
        public DbSet<string> MAT_EXPRESSIONS {  get; set; }
        public string DbPath { get; }
        public CalcDbContext()
        {
            DbPath = "";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
