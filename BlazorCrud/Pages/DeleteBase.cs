using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Pages
{
    public class DeleteBase : ComponentBase
    {
        public bool showModal { get; set; } = false;

        [Parameter]
        public EventCallback<bool> onChangeModelState { get; set; }

        public void show()
        {
            showModal = true;
            StateHasChanged();
        }

        public async Task ChangeShowModalState(bool value)
        {
            showModal = value;
            await onChangeModelState.InvokeAsync(value);
        }
    }
}
