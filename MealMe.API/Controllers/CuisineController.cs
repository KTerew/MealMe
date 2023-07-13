using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MealMe.Models.Models.CuisineModels;
using MealMe.Services.Services.CuisineServices;
using Microsoft.AspNetCore.Mvc;

namespace MealMe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CuisineController : ControllerBase
    {
        private readonly ICuisineServices _cuisineServices;

        public CuisineController(ICuisineServices cuisineServices)
        {
            _cuisineServices = cuisineServices;
        }


        [HttpGet] 
        public async Task<IActionResult> Get()
        {
            List<CuisineListItem> cuisines = await _cuisineServices.GetCuisines();
            return Ok(cuisines);
        }
        

        [HttpGet("{id:int}")] 
        public async Task<IActionResult> Get(int id)
        {
            CuisineDetail cuisine = await _cuisineServices.GetCuisine(id);
            return Ok(cuisine);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CuisineCreate model)
        {
            if (!ModelState.IsValid)
           {
               return BadRequest(ModelState);
            }
            if (await _cuisineServices.CreateCuisine(model))
            {
                return Ok("Cuisine type is created!");
            }
           else 
           return StatusCode(500, "International Server Error.");
       }


        [HttpPut("(id:int)")]
        public async Task<IActionResult> Put(CuisineEdit model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _cuisineServices.UpdateCuisine(model))
            {
                return Ok("Cuisine type created successfully!");
            }
            else {
                return StatusCode(500, "Internal Server Error.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _cuisineServices.DeleteCuisine(id))
            {
                return Ok("Cuisine type deleted!");
            }
            else 
            return StatusCode(500, "International Server Error.");
        }
    }
}