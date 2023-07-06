using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MealMe.Data.Entities;
using MealMe.Models.Models.MealModels;

namespace MealMe.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Meal, MealCreate>().ReverseMap();
            CreateMap<Meal, MealEdit>().ReverseMap();
            CreateMap<Meal, MealListItem>().ReverseMap();
            CreateMap<Meal, MealDetail>().ReverseMap();
        }
    }
}