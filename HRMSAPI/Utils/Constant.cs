using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace HRMSAPI.Utils
{ 
    public static class Constant
    {
        internal static string Facebook = "facebook";
        internal static string Google = "google";

        // Roles
        internal static string AdminRole = "Admin";
        internal static string ManagerRole = "Manager";
        internal static string PlayerRole = "Player";

        internal static string AdminUserName = "admin@example.com";
        internal static string SuperAdminChangeNotAllowed = "Super Admin change is not allowed!";
        internal static int MaximumLoginAttempts = 3;

        public static bool VIPPolicy(AuthorizationHandlerContext context)
        {
            if (context.User.IsInRole(PlayerRole) &&
                context.User.HasClaim(c => c.Type == ClaimTypes.Email && c.Value.Contains("vip")))
            {
                return true;
            }

            return false;
        }
    }
}
