using Abp.MultiTenancy;
using ThinkAM.StackOverflow.Authorization.Users;

namespace ThinkAM.StackOverflow.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
