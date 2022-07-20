using Interface.ViewModels.CarViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface ICar
    {
        Task<GetCarViewModel> GetCar(int id);
        Task<List<GetCarViewModel>> GetCarList();
        Task<bool> InsertCar(InsertCarViewModel model);
        Task<bool> InsertCar(UpdateCarViewModel model);
    }
}
