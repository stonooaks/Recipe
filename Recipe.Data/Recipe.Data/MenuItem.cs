using Hughes.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Data
{
    /// <summary>
    /// MenuItem Class
    /// </summary>
    public class MenuItem : EntityData
    {
        //Recipe information
        public int recipeId { get; set; }
        public virtual Recipe Recipe { get; set; }

        //Date when we are going to have the meal
        [DataType(DataType.Date)]
        public DateTime RecipeDate { get; set; }
    }

    /// <summary>
    /// Recipe Class
    /// </summary>
    public class Recipe : EntityData
    {
        /// <summary>
        /// Deafult constructor 
        /// </summary>
        /// <remarks>
        /// This constructor has a List constructor for IngrediantMeasurement
        /// </remarks>
        public Recipe()
        {
            this.ingrediantMeasurement = new List<IngrediantMeasurement>();
            this.Directions = new List<Direction>();
        }
        
        public string Name { get; set; }
        public string Description { get; set; }

        //This is for the Directions
        public virtual List<Direction> Directions { get; set; }
        public virtual List<IngrediantMeasurement> ingrediantMeasurement { get; set; }
    }

    public class Direction : EntityData
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        [DataType(DataType.MultilineText)]
        public string Line { get; set; }
    }
}
