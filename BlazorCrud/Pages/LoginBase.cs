using Interfaces;
using Interfaces.ViewModels.AuthViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class LoginBase : ComponentBase
    {
        public LoginViewModel model { get; set; } = new();

        [Inject]
        public IAuth authRepo { get; set; }

        protected async Task login()
        {
            LoginResponse loginResponse = await authRepo.login(model);
            Console.WriteLine(loginResponse.token);
        }
    }
}
