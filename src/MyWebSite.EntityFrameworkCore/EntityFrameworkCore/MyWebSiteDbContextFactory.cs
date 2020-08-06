using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyWebSite.Configuration;
using MyWebSite.Web;

namespace MyWebSite.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyWebSiteDbContextFactory : IDesignTimeDbContextFactory<MyWebSiteDbContext>
    {
        public MyWebSiteDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyWebSiteDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyWebSiteDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyWebSiteConsts.ConnectionStringName));

            return new MyWebSiteDbContext(builder.Options);
        }
    }
}
