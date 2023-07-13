using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MealMe.Data.Entities;
using MealMe.Models.Models.CuisineModels;
using MealMe.Models.Models.IngredientModels;
using MealMe.Models.Models.MealModels;

namespace MealMe.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Cuisine,CuisineCreate>().ReverseMap();
            CreateMap<Cuisine,CuisineEdit>().ReverseMap();
            CreateMap<Cuisine,CuisineDetail>().ReverseMap();
            CreateMap<Cuisine,CuisineListItem>().ReverseMap();

            CreateMap<Meal, MealCreate>().ReverseMap();
            CreateMap<Meal, MealEdit>().ReverseMap();
            CreateMap<Meal, MealDetail>().ReverseMap();
            CreateMap<Meal, MealListItem>().ReverseMap();

            CreateMap<Ingredient, IngredientCreate>().ReverseMap();
            CreateMap<Ingredient, IngredientEdit>().ReverseMap();
            CreateMap<Ingredient, IngredientDetail>().ReverseMap();
            CreateMap<Ingredient, IngredientListItem>().ReverseMap();
        }
    }
}