using Boilerplate.Data.Models;

namespace Boilerplate.Business.Services.Interfaces
{
    public interface IJwtService
    {
        public string GenerateJwtToken(User user);
    }
}
