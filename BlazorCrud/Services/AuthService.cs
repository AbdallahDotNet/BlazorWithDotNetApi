using Blazored.LocalStorage;
using Interfaces;
using Interfaces.ViewModels.AuthViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public class AuthService : IAuth
    {
        private HttpClient _httpClient;
        private ILocalStorageService _localStorage;
        public AuthService(HttpClient httpClient,
            ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public JwtSecurityToken GenerateAccessTokent(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponse> login(LoginViewModel model)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/auths", model);
            LoginResponse returnValue = await response.Content.ReadAsAsync<LoginResponse>();

            await _localStorage.SetItemAsync("token", returnValue.token);
            return returnValue;
        }
    }
}
