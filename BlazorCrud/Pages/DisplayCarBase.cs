using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class DisplayCarBase : ComponentBase
    {
        [Inject]
        private ICar carRepo { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        [Parameter]
        public GetCarViewModel carViewModel { get; set; } = new GetCarViewModel();

        public DeleteBase deleteBase { get; set; }

        [Parameter]
        public EventCallback<bool> refillCarList { get; set; }

        protected void showModal()
        {
            deleteBase.show();
        }

        protected async Task Delete(bool value)
        {
            if (value)
            {
                bool result = await carRepo.DeleteCar(carViewModel.id);
                Console.WriteLine(result);
                if (result)
                {
                    navigationManager.NavigateTo("/");
                    await refillCarList.InvokeAsync(true);
                }
                else
                {
                    navigationManager.NavigateTo("/add");
                }
            }
        }
    }
}
