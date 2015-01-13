using Hughes.DbContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Data {



    /// <summary>
    /// Recipe Context for the Recipe Database
    /// </summary>
    /// <remarks>
    /// It inherits the DbContextBase from the Hughes Library
    /// </remarks>
    public class RecipeContext : DbContextBase
    {
        public DbSet<Direction> Directions { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Ingrediant> Ingrediants { get; set; }
        public DbSet<IngrediantMeasurement> IngrediantMeasurements { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

    }
}
