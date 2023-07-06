using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMe.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MealMe.Data.MealMeContext
{
    public class MealMeDBContext : DbContext
    {
        public MealMeDBContext(DbContextOptions options) : base(options) {}

        public DbSet<Meal> Meals { get; set; }
        // public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
    }
}