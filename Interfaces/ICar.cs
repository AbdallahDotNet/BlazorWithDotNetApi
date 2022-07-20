using Entitis.Models;
using Interfaces.ViewModels.CarViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICar
    {
        Task<Cars> GetCarEntity(int id);
        Task<GetCarViewModel> GetCar(int id);
        Task<List<GetCarViewModel>> GetCarList();
        Task<InsertCarViewModel> InsertCar(InsertCarViewModel model);
        Task<UpdateCarViewModel> UpdateCar(UpdateCarViewModel model);
        Task<bool> DeleteCar(int id);
    }
}
