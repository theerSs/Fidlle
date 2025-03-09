using AutoMapper;
using Fidlle.Application.DTO;
using Fidlle.Application.Exceptions;
using Fidlle.Application.Interfaces;
using Fidlle.Application.IRepositories;
using Fidlle.Application.Services.Interfaces;
using Fidlle.Domain.Entities;

namespace Fidlle.Application.Services.Implementations
{
    public class UserService(IUserRepository userRepository, IPasswordService passwordService, IMapper mapper) : IUserService
    {
        public async Task<Guid?> AuthenticateAsync(LoginDto loginDto)
        {
            var user = await userRepository.GetUserByEmailAsync(loginDto.Email);
            if (user == null || !passwordService.VerifyPassword(user.PasswordHash, loginDto.Password))
            {
                throw new UnauthorizedAccessException("Wrong email or password");
            }

            return user.Id;
        }

        public async Task<bool> CreateUserAsync(RegisterDto registerDto)
        {
            var existingEmailUser = await userRepository.GetUserByEmailAsync(registerDto.Email);
            if (existingEmailUser != null)
            {
                throw new BadRequestException("A user with this email already exists.");
            }

            var existingUsernameUser = await userRepository.GetUserByUsernameAsync(registerDto.Username);
            if (existingUsernameUser != null){
                throw new BadRequestException("A user with this username already exists.");
            }

            var user = mapper.Map<User>(registerDto);
            user.PasswordHash = passwordService.HashPassword(registerDto.Password);

            await userRepository.CreateUserAsync(user);
            await userRepository.SaveChangesAsync();

            return true;
        }

    }
}
