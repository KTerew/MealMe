using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Services.Services.IngredientServices;

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

        public async Task<bool>CreateIngredient(IngredientCreate model)
        {
            var entity = _mapper.Map<Ingredient>(model);

            await _context.Ingredient.AddAsync(entity);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteIngredient(int Id)
        {
            var ingredient = await _context.Ingredient.FindAsync(Id);
            if(ingredient is null) return false;

            _context.Ingredients.Remove(ingredient);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<List<IngredientDetail>> GetIngredients(int Id)
        {
            var ingredients = await _context.Ingredients.ToListAsync();
            var ingredientDetails = _mapper.Map<List<IngredientListItem>>(Ingredients);
            return ingredientListItems;
        }

        public async Task<IngredientDetail> GetIngredient(Int id)
       {
        var ingredient = await _context.Ingredients.Include(c => i.Ingredients).SingleOrDefaultAsync(x = x.Id == id);
        if (ingredient is null) return null;

        var ingredientDetail = _mapper.Map<ingredientDetail>(ingredient);
        return ingredientDetail;
       }

       public async Task<bool> UpdateIngredient(IngredientEdit model)
       {
        var ingredient = await _context.Ingredients.FindAsync(model.IngredientId);
        if (ingredient == null)
        {
            return false;
        }
        ingredient.Name = model.Name;
        ingredient.Category = model.Category;
        ingredient.Quantity = model.Quanitity;

        await _context.SaveChangesAsync();
        return true;
       }
    }
}