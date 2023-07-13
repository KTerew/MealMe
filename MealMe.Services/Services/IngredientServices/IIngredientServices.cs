using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Models.Models.IngredientModels;

namespace MealMe.Services.Services.IngredientServices
{
    public interface IIngredientServices
    {
        Task<bool> IngredientCreate(IngredientCreate model);

        Task<bool>EditIngredient(IngredientEdit model);

        Task<bool>DeleteIngredient(int id);

        Task <IngredientDetail>GetIngredient(int id);
        Task<List<IngredientListItem>>GetIngredients();
    }
}
