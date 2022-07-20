using Interfaces;
using Interfaces.ViewModels.AuthViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Api.Services
{
    public class AuthService : IAuth
    {
        private IConfiguration _configuration;
        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public JwtSecurityToken GenerateAccessTokent(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var auth_key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));

            int.TryParse(_configuration["JWT:TokenValidityInMintes"], out int TokenValidityInMintes);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(TokenValidityInMintes),
                claims: claims,
                signingCredentials: new SigningCredentials(auth_key, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        public async Task<LoginResponse> login(LoginViewModel model)
        {
            LoginResponse response = new();

            if (model.email.ToLower() == "test@gmail.com" && model.password.ToLower() == "test")
            {
                response = new() { token = new JwtSecurityTokenHandler().WriteToken(GenerateAccessTokent("test"))};
            }
            else
            {
                response = new();
            }

            return response;
        }
    }
}
