using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Data.Entities;

namespace MealMe.Models.Models.MealModels
{
    public class MealListItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Calories { get; set; }

        public int PrepTime { get; set; }
    }
}