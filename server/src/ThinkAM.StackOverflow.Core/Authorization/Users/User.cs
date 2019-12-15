using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization.Users;
using Abp.Extensions;

namespace ThinkAM.StackOverflow.Authorization.Users
{
    [Table("Usuario")]
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        [Column("Usuario")]
        public override string UserName { get; set; }

        [Column("Email")]
        public override string EmailAddress { get; set; }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
