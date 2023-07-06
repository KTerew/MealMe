using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MealMe.Data.Entities
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public int PrepTime { get; set; }

        public int? CuisineId { get; set; }
        
        [ForeignKey(nameof(CuisineId))]
        public virtual Cuisine? Cuisine { get; set; }
        
        // public virtual List<Ingredient> Ingredients { get; set; }

        // public double Price
        // {
        //     get
        //     {
        //         if(Ingredients.Count == 0)
        //             return 0;

        //         double total = 0.0;
        //         foreach (Ingredient ingredient in Ingredients)
        //         {
        //             total += ingredient.Price;
        //         }
        //         return total;
        //     }
        // }
    }
}