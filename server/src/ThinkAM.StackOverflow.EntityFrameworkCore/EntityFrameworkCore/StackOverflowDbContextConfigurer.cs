using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThinkAM.StackOverflow.EntityFrameworkCore
{
    public static class StackOverflowDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StackOverflowDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StackOverflowDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
