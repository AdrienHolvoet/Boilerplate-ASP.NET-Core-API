using Boilerplate.Business.DTOs.Authentication;
using Boilerplate_REST.Business.DTOs;
using Boilerplate_REST.Data.Models;
using System.Threading.Tasks;

namespace Boilerplate_REST.Business.Services.Interfaces
{
    public interface IAuthenticationService
    {
        public User Authenticate(AuthenticateRequestDto requestDto);
        public User RefreshToken(RefreshTokenRequestDto token);
        public string GetToken(User user);
        public User AddUser(UserRequestDto requestDto);
        public Task<User> AuthenticateWithFacebookAsync(string token);
    }
}