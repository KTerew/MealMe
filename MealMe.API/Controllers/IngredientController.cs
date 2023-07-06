using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MealMe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientController : ControllerBase
    {
         private readonly IIngredientServices _ingredientServices;

        public IngredientController(IIngredientServices ingredientServices)
        {
            _ingredientServices = ingredientServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateIngredient(IngredientCreate model)
        {
            bool createIngredient = await _ingredientServices.CreateMeal(model);
            return Ok(createIngredient);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            bool deleteIngredient = await _ingredientServices.DeleteIngredient(id);
            return Ok(deleteIngredient);
        }

        [HttpGet]
        public async Task<IActionResult> GetIngredients()
        {
            List<IngredientListItem> getIngredients = await _ingredientServices.GetIngredients();
            return Ok(getIngredients);
        }

        [HttpGet]
        public async Task<IActionResult> GetIngredients(int id)
        {
            IngredientDetail getIngredient = await _ingredientServices.GetIngredient(id);
            return Ok(getIngredient);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateIngredients(IngredientEdit model)
        {
            bool updateIngredient = await _ingredientServices.UpdateIngredient(model);
            return Ok(updateIngredient);
        }
    }
}
