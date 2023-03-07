using FarmFreshApiService.Authentication.Models;

namespace FarmFreshApiService.Authentication.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
