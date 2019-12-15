using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ThinkAM.StackOverflow.Controllers
{
    public abstract class StackOverflowControllerBase: AbpController
    {
        protected StackOverflowControllerBase()
        {
            LocalizationSourceName = StackOverflowConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
