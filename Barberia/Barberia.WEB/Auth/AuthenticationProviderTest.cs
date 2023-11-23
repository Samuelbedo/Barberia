using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Barberia.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            await Task.Delay(3000);

            var anonimous = new ClaimsIdentity();

            var oapUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Luis"),
            new Claim("LastName", "O"),
            new Claim(ClaimTypes.Name, "oap@yopmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
        },
                authenticationType: "test");

            var clienteUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Santiago"),
            new Claim("LastName", "Varela"),
            new Claim(ClaimTypes.Name, "clienteLindo@yopmail.com"),
            new Claim(ClaimTypes.Role, "Usuario")
        },
                authenticationType: "test");

            var barberoUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Samuel"),
            new Claim("LastName", "Bedoya"),
            new Claim(ClaimTypes.Name, "barberoPrecioso@yopmail.com"),
            new Claim(ClaimTypes.Role, "Barbero")
        },
                authenticationType: "test");


            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonimous)));//CON OAP AUTORIZA, CON ANONIMOUS NO
        }
    }
}
