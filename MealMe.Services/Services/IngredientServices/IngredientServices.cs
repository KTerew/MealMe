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
        public IngredientServices(MealMeDBContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<bool>CreateIngredient(IngredientCreate model)
        {
            var entity = new IngredientServices
            {
                Name = model.Name
            };
        }
    }
}