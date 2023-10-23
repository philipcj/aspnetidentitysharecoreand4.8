using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace AspNetCoreLoginApp.Areas.Identity;

public class IdentityUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<IdentityUser>
{
    public IdentityUserClaimsPrincipalFactory(UserManager<IdentityUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
    }

    protected async override Task<ClaimsIdentity> GenerateClaimsAsync(IdentityUser user)
    {
        var identity = await base.GenerateClaimsAsync(user);

        identity.AddClaim(new Claim(ClaimTypes.Role, "AdminClaim"));

        return identity;
    }
}