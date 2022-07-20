using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [EnableCors("Cors")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICar _repo;
        public CarsController(ICar repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                GetCarViewModel result = await _repo.GetCar(id);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest((string.IsNullOrEmpty(ex.InnerException.ToString())? ex.Message : ex.InnerException));
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<GetCarViewModel> result = await _repo.GetCarList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest((string.IsNullOrEmpty(ex.InnerException.ToString()) ? ex.Message : ex.InnerException));
            }
        }

        [HttpPost("insert")]
        public async Task<IActionResult> Insert(InsertCarViewModel model)
        {
            try
            {
                InsertCarViewModel res = await _repo.InsertCar(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest((string.IsNullOrEmpty(ex.InnerException.ToString()) ? ex.Message : ex.InnerException));
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(UpdateCarViewModel model)
        {
            try
            {
                UpdateCarViewModel res = await _repo.UpdateCar(model);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest((string.IsNullOrEmpty(ex.InnerException.ToString()) ? ex.Message : ex.InnerException));
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool result = await _repo.DeleteCar(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest((string.IsNullOrEmpty(ex.InnerException.ToString()) ? ex.Message : ex.InnerException));
            }
        }
    }
}
