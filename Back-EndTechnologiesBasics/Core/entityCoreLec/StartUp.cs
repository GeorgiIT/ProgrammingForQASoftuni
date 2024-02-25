
using entityCoreLec.Data;
using Microsoft.EntityFrameworkCore;

namespace entityCoreLec
{
    public class StartUp
    {
        static async Task Main(string[] args)
        {
            var contextFactory = new PersonRegisterDbContextFactory();
            var dbContext = contextFactory.CreateDbContext(args);

            await dbContext.Database.MigrateAsync();
        }
    }
}
