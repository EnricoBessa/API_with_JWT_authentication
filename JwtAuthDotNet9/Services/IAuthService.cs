using JwtAuthDotNet9.Entities;
using JwtAuthDotNet9.Models;
using Microsoft.AspNetCore.Identity;
using JwtAuthDotNet9.Entities;

namespace JwtAuthDotNet9.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDTO request);

        Task<string?> LoginAsync(UserDTO request);
    }
}
