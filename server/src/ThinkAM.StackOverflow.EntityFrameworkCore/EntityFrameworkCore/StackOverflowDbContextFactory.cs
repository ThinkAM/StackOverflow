using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ThinkAM.StackOverflow.Configuration;
using ThinkAM.StackOverflow.Web;

namespace ThinkAM.StackOverflow.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StackOverflowDbContextFactory : IDesignTimeDbContextFactory<StackOverflowDbContext>
    {
        public StackOverflowDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StackOverflowDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StackOverflowDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StackOverflowConsts.ConnectionStringName));

            return new StackOverflowDbContext(builder.Options);
        }
    }
}
