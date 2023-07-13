using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MealMe.Data.Entities;
using MealMe.Data.MealMeContext;
using MealMe.Models.Models.IngredientModels;
using MealMe.Services.Services.IngredientServices;
using Microsoft.EntityFrameworkCore;

namespace MealMe.Services.Services.IngredientServices
{
    public class IngredientServices : IIngredientServices
    {
        private readonly MealMeDBContext _context;
        private readonly IMapper _mapper;
        public IngredientServices(MealMeDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> DeleteIngredient(int Id)
        {
            var ingredient = await _context.Ingredients.FindAsync(Id);
            if(ingredient is null) return false;

            _context.Ingredients.Remove(ingredient);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> EditIngredient(IngredientEdit model)
       {
        var ingredient = await _context.Ingredients.FindAsync(model.Id);
        if (ingredient == null)
        {
            return false;
        }
        ingredient.Name = model.Name;
        ingredient.Price = model.Price;
        ingredient.Quantity = model.Quantity;
        ingredient.MealsId = model.MealsId;

        await _context.SaveChangesAsync();
        return true;
       } 

        public async Task<IngredientDetail> GetIngredient(int id)
       {
        var ingredient = await _context.Ingredients.Include(i => i.Meal).SingleOrDefaultAsync(x => x.Id == id);
        if (ingredient is null) return null;

        var ingredientDetail = _mapper.Map<IngredientDetail>(ingredient);
        return ingredientDetail;
       }
        public async Task<List<IngredientListItem>> GetIngredients()
        {
            var ingredients = await _context.Ingredients.ToListAsync();
            var ingredientListItems = _mapper.Map<List<IngredientListItem>>(ingredients);
            return ingredientListItems;
        }

        public async Task<bool>IngredientCreate(IngredientCreate model)
        {
            var entity = _mapper.Map<Ingredient>(model);

            await _context.Ingredients.AddAsync(entity);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
