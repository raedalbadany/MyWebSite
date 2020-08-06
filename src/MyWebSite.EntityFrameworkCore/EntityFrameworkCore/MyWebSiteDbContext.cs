using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyWebSite.Authorization.Roles;
using MyWebSite.Authorization.Users;
using MyWebSite.MultiTenancy;

namespace MyWebSite.EntityFrameworkCore
{
    public class MyWebSiteDbContext : AbpZeroDbContext<Tenant, Role, User, MyWebSiteDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyWebSiteDbContext(DbContextOptions<MyWebSiteDbContext> options)
            : base(options)
        {
        }
    }
}
