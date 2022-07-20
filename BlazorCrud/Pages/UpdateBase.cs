using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class UpdateBase : ComponentBase
    {
        protected bool showError { get; set; } = false;
        protected string errorMessage { get; set; }

        [Parameter]
        public string id { get; set; }

        [Inject]
        public ICar carRepo { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        protected GetCarViewModel car { get; set; } = new();
        protected UpdateCarViewModel model { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            car = await carRepo.GetCar(int.Parse(id));
            model.name = car.name;
        }

        protected async Task Update()
        {
            model.id = int.Parse(id);
            UpdateCarViewModel result = await carRepo.UpdateCar(model);
            if (result.isComplete)
            {
                navigationManager.NavigateTo("/");
            }
            else
            {
                navigationManager.NavigateTo($"/update/{model.id}");
                showError = true;
                errorMessage = "kkfd";
            }
        }
    }
}
