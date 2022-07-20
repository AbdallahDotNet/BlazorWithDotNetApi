using Entitis.Models;
using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace BlazorCrud.Services
{
    public class CarService : ICar
    {
        private HttpClient _httpClient;
        public CarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> DeleteCar(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/cars/{id}");
            bool returnValue = await response.Content.ReadAsAsync<bool>();

            return returnValue;
        }

        public async Task<GetCarViewModel> GetCar(int id)
        {
            return await _httpClient.GetFromJsonAsync<GetCarViewModel>($"api/cars/{id}");
        }

        public Task<Cars> GetCarEntity(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetCarViewModel>> GetCarList()
        {
            return await _httpClient.GetFromJsonAsync<List<GetCarViewModel>>("api/cars");
        }

        public async Task<InsertCarViewModel> InsertCar(InsertCarViewModel model)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/cars/insert", model);
            InsertCarViewModel returnValue = await response.Content.ReadAsAsync<InsertCarViewModel>();

            return returnValue;
        }

        public async Task<UpdateCarViewModel> UpdateCar(UpdateCarViewModel model)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/cars/update", model);
            UpdateCarViewModel returnValue = await response.Content.ReadAsAsync<UpdateCarViewModel>();

            return returnValue;
        }
    }
}
