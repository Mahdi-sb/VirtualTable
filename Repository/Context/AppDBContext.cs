

using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> dbContextOptions) 

            : base(dbContextOptions)
        {

        }


        public DbSet<Tables> Tables { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Value> Values { get; set; }
        public DbSet<CreateTime> CreateTimes { get; set; }


    }
}
