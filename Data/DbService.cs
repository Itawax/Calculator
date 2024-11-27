

using Microsoft.EntityFrameworkCore;

namespace Calculator.Data
{
    public class DbService
    {
        CalcDbContext dbContext = new CalcDbContext();
        public DbService() 
        { }

        public void InsertNewExpression(string matExpression)
        {
            dbContext.Database.ExecuteSqlRaw($"INSERT INTO MAT_EXPRESSIONS (EXPRESSION, DATE) VALUES ('{matExpression}', {DateTime.Now})");
            dbContext.SaveChanges();
        }
    }
}
