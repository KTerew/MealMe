using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Models.Models.CuisineModels;



namespace MealMe.Services.Services.CuisineServices
{
    public interface ICuisineServices
    {
        public Task<bool>CreateCuisine(CuisineCreate model);
        public Task<bool>UpdateCuisine(CuisineEdit model);
        public Task<bool>DeleteCuisine(int Id);
        public Task<CuisineDetail>GetCuisine(int id);
        public Task<List<CuisineDetail>>GetCuisines();
    }
}