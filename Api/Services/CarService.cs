using Api.Services.Model;
using AutoMapper;
using Entitis.Models;
using Interfaces;
using Interfaces.ViewModels.CarViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class CarService : ICar
    {
        private DataContext _context;
        private IMapper _mapper;
        public CarService(DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteCar(int id)
        {
            Cars car = _mapper.Map<Cars>(await GetCarEntity(id));
            _context.Remove(car);

            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<GetCarViewModel> GetCar(int id)
        {
            Cars car = await _context.Cars.FirstOrDefaultAsync(x => x.id == id);
            return _mapper.Map<GetCarViewModel>(car);
        }

        public async Task<Cars> GetCarEntity(int id)
        {
            Cars car = await _context.Cars.FirstOrDefaultAsync(x => x.id == id);
            return car;
        }

        public async Task<List<GetCarViewModel>> GetCarList()
        {
            List<Cars> cars = await _context.Cars.ToListAsync();
            return _mapper.Map<List<GetCarViewModel>>(cars);
        }

        public async Task<InsertCarViewModel> InsertCar(InsertCarViewModel model)
        {
            Cars car = _mapper.Map<Cars>(model);
            _context.Add(car);

            InsertCarViewModel returnValue = new();

            bool result = await _context.SaveChangesAsync() > 0;
            if (result)
            {
                model.isComplete = true;
                returnValue = model;
            }
            else
            {
                model.isComplete = false;
                returnValue = null;
            }

            return returnValue;
        }

        public async Task<UpdateCarViewModel> UpdateCar(UpdateCarViewModel model)
        {
            Cars car = _mapper.Map<Cars>(await GetCarEntity(model.id));
            _mapper.Map(model, car);

            UpdateCarViewModel returnValue = new();

            bool result = await _context.SaveChangesAsync() > 0;
            if (result)
            {
                model.isComplete = true;
                returnValue = model;
            }
            else
            {
                model.isComplete = false;
                returnValue = null;
            }

            return returnValue;
        }
    }
}
