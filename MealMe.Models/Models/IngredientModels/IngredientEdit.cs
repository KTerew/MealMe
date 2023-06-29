using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealMe.Models.Models.IngredientModels
{
    public class IngredientEdit
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name {get; set;} 
        [Required]
        public double Price {get; set;}
        [Required]
        public int Quantity {get; set;}
        [Required]
        [ForeignKey(nameof(MealsId))]
        public int MealsId {get; set;}
    }
}