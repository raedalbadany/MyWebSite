using Abp.Authorization;
using MyWebSite.Authorization.Roles;
using MyWebSite.Authorization.Users;

namespace MyWebSite.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
