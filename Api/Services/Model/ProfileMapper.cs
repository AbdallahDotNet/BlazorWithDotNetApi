using AutoMapper;
using Entitis.Models;
using Interfaces.ViewModels.CarViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.Model
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Cars, GetCarViewModel>().ReverseMap();
            CreateMap<InsertCarViewModel, Cars>();
            CreateMap<UpdateCarViewModel, Cars>();
        }
    }
}
