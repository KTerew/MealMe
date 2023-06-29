using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Models.Models.CuisineModels;

namespace MealMe.Services.Services.CuisineServices
{
    public class CuisineServices : ICuisineServices
    {
        public Task<bool> CreateCuisine(CuisineCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCuisine(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<CuisineDetail> GetCuisine(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CuisineDetail>> GetCuisines()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCuisine(CuisineEdit model)
        {
            throw new NotImplementedException();
        }
    }
}