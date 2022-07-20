using Interfaces;
using Interfaces.ViewModels.AuthViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private IAuth _repo;
        public AuthsController(IAuth repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            try
            {
                LoginResponse result = await _repo.login(model);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest((string.IsNullOrEmpty(ex.InnerException.ToString()) ? ex.Message : ex.InnerException));
            }
        }
    }
}
