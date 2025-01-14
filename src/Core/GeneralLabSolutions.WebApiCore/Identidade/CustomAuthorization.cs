using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GeneralLabSolutions.WebApiCore.Identidade
{
    public static class CustomAuthorization
    {
        public static bool EhSuperAdmin(HttpContext context)
        {
            return PossuiRole(context, "SuperAdmin");
        }

        public static bool ValidarClaimsUsuario(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity!.IsAuthenticated &&
                   context.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }

        public static bool PossuiRole(HttpContext context, string role)
        {
            return context.User.IsInRole(role);
        }
    }

    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue, string? role = null)
            : base(typeof(RequisitoClaimFilter))
        {
            Arguments = new object [] { new Claim(claimName, claimValue), role };
        }
    }

    public class RequisitoClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;
        private readonly string? _role;

        public RequisitoClaimFilter(Claim claim, string? role)
        {
            _claim = claim;
            _role = role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity!.IsAuthenticated)
            {
                context.Result = new StatusCodeResult(401);
                return;
            }

            // Verificar se o usuário é SuperAdmin (acesso irrestrito)
            if (CustomAuthorization.EhSuperAdmin(context.HttpContext))
            {
                return; // Permite o acesso
            }

            if ((!CustomAuthorization.ValidarClaimsUsuario(context.HttpContext, _claim.Type, _claim.Value)
                && !CustomAuthorization.PossuiRole(context.HttpContext, _role!)))
            {
                context.Result = new StatusCodeResult(403);
            }
        }
    }
}