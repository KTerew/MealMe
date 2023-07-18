using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MealMe.Data.Entities;
using MealMe.Data.MealMeContext;
using MealMe.Models.Models.MealModels;
using Microsoft.EntityFrameworkCore;

namespace MealMe.Services.Services.MealServices
{
    public class MealServices : IMealServices
    {
        private readonly MealMeDBContext _context;
        private IMapper _mapper;

        public MealServices(MealMeDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateMeal(MealCreate model)
        {
            var meal = _mapper.Map<Meal>(model);

            await _context.Meals.AddAsync(meal);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteMeal(int id)
        {
            var meal = await _context.Meals.FindAsync(id);
            if(meal is null)
                return false;

            _context.Meals.Remove(meal);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<MealDetail> GetMeal(int id)
        {
            var meal = await _context.Meals.Include(c=>c.Cuisine).Include(i=>i.Ingredients).FirstOrDefaultAsync(x=>x.Id == id);
            if(meal is null)
                return new MealDetail();
            
            var MealDetail = _mapper.Map<MealDetail>(meal);

            return MealDetail;
        }

        public async Task<List<MealListItem>> GetMeals()
        {
            var meals = await _context.Meals.ToListAsync();
            var mealListItem = _mapper.Map<List<MealListItem>>(meals);

            return mealListItem;
        }

        public async Task<bool> UpdateMeal(MealEdit model)
        {
            var meal = await _context.Meals.FirstOrDefaultAsync(x=>x.Id == model.Id);

            var conversion = _mapper.Map<MealEdit,Meal>(model, meal);
            _context.Meals.Update(conversion);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<MealDetail> GetRandomMeal()
        {
            var list = await _context.Meals.Include(c=>c.Cuisine).Include(i=>i.Ingredients).ToListAsync();
            Random rnd = new Random();
            int index = rnd.Next(list.Count());
            var meal = list[index];

            var MealDetail = _mapper.Map<MealDetail>(meal);
            return MealDetail;
        }
    }
}