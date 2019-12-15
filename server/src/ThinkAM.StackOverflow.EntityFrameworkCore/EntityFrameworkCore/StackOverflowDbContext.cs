using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ThinkAM.StackOverflow.Authorization.Roles;
using ThinkAM.StackOverflow.Authorization.Users;
using ThinkAM.StackOverflow.MultiTenancy;

namespace ThinkAM.StackOverflow.EntityFrameworkCore
{
    public class StackOverflowDbContext : AbpZeroDbContext<Tenant, Role, User, StackOverflowDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StackOverflowDbContext(DbContextOptions<StackOverflowDbContext> options)
            : base(options)
        {
        }
    }
}
