using Interfaces.ViewModels.AuthViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class LoginResponse
    {
        public string token { get; set; }
    }

    public interface IAuth
    {
        Task<LoginResponse> login(LoginViewModel model);
        JwtSecurityToken GenerateAccessTokent(string userName);
    }
}
