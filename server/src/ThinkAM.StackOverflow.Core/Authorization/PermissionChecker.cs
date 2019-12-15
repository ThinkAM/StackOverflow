using Abp.Authorization;
using ThinkAM.StackOverflow.Authorization.Roles;
using ThinkAM.StackOverflow.Authorization.Users;

namespace ThinkAM.StackOverflow.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
