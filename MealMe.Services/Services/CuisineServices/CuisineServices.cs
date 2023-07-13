using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MealMe.Data.Entities;
using MealMe.Data.MealMeContext;
using MealMe.Models.Models.CuisineModels;
using Microsoft.EntityFrameworkCore;

namespace MealMe.Services.Services.CuisineServices
{
    public class CuisineServices : ICuisineServices
    {
        private readonly MealMeDBContext _context;

        private readonly IMapper _mapper;

        public CuisineServices(MealMeDBContext context, IMapper mapper)
        {
           _context = context;
           _mapper = mapper; 
        }

        public async Task<bool> CreateCuisine(CuisineCreate model)
        {
            var cuisine = _mapper.Map<Cuisine>(model);

            await _context.Cuisines.AddAsync(cuisine);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteCuisine(int Id)
        {
            var cuisine = await _context.Cuisines.FindAsync(Id);
            if (cuisine is null) return false;

            _context.Cuisines.Remove(cuisine);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<CuisineDetail> GetCuisine(int id)
        {
            var cuisine = await _context.Cuisines.SingleOrDefaultAsync(x => x.Id == id);
            
            if (cuisine is null) return new CuisineDetail{};

            return _mapper.Map<CuisineDetail>(cuisine);
        }

        public async Task<List<CuisineListItem>> GetCuisines()
        {
            var cuisines = await _context.Cuisines.ToListAsync();
            var cuisineListItems = _mapper.Map<List<CuisineListItem>>(cuisines);
            return cuisineListItems;

        }

        public async Task<bool> UpdateCuisine(CuisineEdit model)
        {
            var cuisine = await _context.Cuisines.AsNoTracking().SingleOrDefaultAsync(x => x.Id == model.Id);

            if (cuisine is null) return false;

            var conversion = _mapper.Map<CuisineEdit,Cuisine>(model);

            _context.Cuisines.Update(conversion);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}