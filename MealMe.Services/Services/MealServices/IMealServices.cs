using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Models.Models.MealModels;

namespace MealMe.Services.Services.MealServices
{
    public interface IMealServices
    {
        Task<bool> CreateMeal(MealCreate model);
        Task<bool> UpdateMeal(MealEdit model);
        Task<bool> DeleteMeal(int id);
        Task<MealDetail> GetMeal(int id);
        Task<List<MealListItem>> GetMeals();
    }
}