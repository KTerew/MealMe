using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealMe.Models.Models.IngredientModels
{
    public class IngredientCreate
    {
        [Required]
        public string Name {get; set;}
        [Required]
        public double Price {get; set;}
        [Required]
        public int Quantity {get; set;}
        [Required]
        public int MealsId {get; set;}
    }
}