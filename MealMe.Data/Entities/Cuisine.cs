using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealMe.Data.Entities
{
    public class Cuisine
    {
        [Key]
        public int Id { get; set; } 

        [Required]  
        [MaxLength(200)] 
        public string Name { get; set; }   

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [MaxLength(200)]
        public string Style { get; set; }
    }
}