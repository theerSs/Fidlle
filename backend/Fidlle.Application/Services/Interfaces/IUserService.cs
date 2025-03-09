using Fidlle.Application.DTO;

namespace Fidlle.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> CreateUserAsync(RegisterDto registerDto);
        Task<Guid?> AuthenticateAsync(LoginDto loginDto);
    }
}
