using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Data.Entities;

namespace MealMe.Data.Entities
{
    public class Ingredient
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