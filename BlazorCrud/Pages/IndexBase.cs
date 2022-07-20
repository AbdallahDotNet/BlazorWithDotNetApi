using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public ICar carRepo { get; set; }

        protected List<GetCarViewModel> CarsList { get; set; } = new List<GetCarViewModel>();

        protected override async Task OnInitializedAsync()
        {
            CarsList = await carRepo.GetCarList();
        }

        protected async Task Refill(bool value)
        {
            if (value)
                CarsList = await carRepo.GetCarList();
        }
    }
}
