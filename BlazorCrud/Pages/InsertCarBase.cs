using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class InsertCarBase : ComponentBase
    {
        protected bool showError { get; set; } = false;
        protected string errorMessage { get; set; }

        [Inject]
        public ICar carRepo { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        protected InsertCarViewModel model { get; set; } = new();

        protected async Task Insert()
        {
            InsertCarViewModel task = await carRepo.InsertCar(model);
            Console.WriteLine(task.isComplete);
            if (task.isComplete)
            {
                navigationManager.NavigateTo("/");
            }
            else
            {
                navigationManager.NavigateTo("/add");
                showError = true;
                errorMessage = "kkfd";
            }
        }
    }
}
