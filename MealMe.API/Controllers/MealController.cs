using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Models.Models.MealModels;
using MealMe.Services.Services.MealServices;
using Microsoft.AspNetCore.Mvc;

namespace MealMe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {
        private readonly IMealServices _mealServices;

        public MealController(IMealServices mealServices)
        {
            _mealServices = mealServices;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMeal(MealCreate model)
        {
            bool createMeal = await _mealServices.CreateMeal(model);
            return Ok(createMeal);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMeal(int id)
        {
            bool deleteMeal = await _mealServices.DeleteMeal(id);
            return Ok(deleteMeal);
        }

        [HttpGet]
        public async Task<IActionResult> GetMeals()
        {
            List<MealListItem> getMeals = await _mealServices.GetMeals();
            return Ok(getMeals);
        }

        [HttpGet]
        public async Task<IActionResult> GetMeal(int id)
        {
            MealDetail getMeal = await _mealServices.GetMeal(id);
            return Ok(getMeal);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMeal(MealEdit model)
        {
            bool updateMeal = await _mealServices.UpdateMeal(model);
            return Ok(updateMeal);
        }
    }
}