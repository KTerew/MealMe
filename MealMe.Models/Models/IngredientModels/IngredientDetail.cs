using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MealMe.Models.Models.IngredientModels
{
    public class IngredientDetail
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name {get; set;} 

        public double Price {get; set;}

        public int Quantity {get; set;}

        [ForeignKey(nameof(MealsId))]
        public int MealsId {get; set;}
    }
}