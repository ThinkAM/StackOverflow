using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using ThinkAM.StackOverflow.Authorization.Roles;
using ThinkAM.StackOverflow.Authorization.Users;
using ThinkAM.StackOverflow.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace ThinkAM.StackOverflow.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
