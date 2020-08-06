using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyWebSite.EntityFrameworkCore
{
    public static class MyWebSiteDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyWebSiteDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyWebSiteDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
