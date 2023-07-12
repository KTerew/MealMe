using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Data.Entities;

namespace MealMe.Models.Models.MealModels
{
    public class MealDetail
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public int Calories { get; set; }

        public int PrepTime { get; set; }

        public virtual Cuisine Cuisine { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }

        public double Price
        {
            get
            {
                if(Ingredients.Count == 0)
                    return 0;

                double total = 0.0;
                foreach (Ingredient ingredient in Ingredients)
                {
                    total += ingredient.Price;
                }
                return total;
            }
        }
    }
}