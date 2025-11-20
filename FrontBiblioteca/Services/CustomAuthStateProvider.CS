using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Components.Authorization;

namespace FrontBiblioteca.Services
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal _CurrentUser = new ClaimsPrincipal(new ClaimsIdentity());

        public IEnumerable<ClaimsIdentity> IdentityClaims { get; private set; }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(_CurrentUser));
        }

        public void login(string username)
        {
            var identityClaims = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.Name, username)
          }, "FakeAuth");

            _CurrentUser = new ClaimsPrincipal(IdentityClaims);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
                public void LogOut()
                {
                    _CurrentUser = new ClaimsPrincipal(new ClaimsIdentity());
                    NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());

                }
            }
       


        }



    

