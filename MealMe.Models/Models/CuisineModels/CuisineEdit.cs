using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealMe.Models.Models.CuisineModels
{
    public class CuisineEdit
    {
        [Required]
        public int Id { get; set; } 

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }   

        [MaxLength(200)]
        [Required]
        public string Description { get; set; }

        [MaxLength(200)]
        [Required]
        public string Style { get; set; }
    }
}