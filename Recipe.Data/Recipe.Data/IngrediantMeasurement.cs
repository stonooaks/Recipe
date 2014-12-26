using Hughes.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe.Data
{
    /// <summary>
    /// Ingrediant Measurement object class
    /// </summary>
    /// <remarks>
    /// This class is to combine a measurement type and amount with
    /// a Ingrediant
    /// </remarks>
    public class IngrediantMeasurement : EntityData
    {
        //This is the amount of for measuremtn
        public int MeasurementAmount { get; set; }
        public MeasurementType measurementType { get; set; }

        //This is the Ingrediant Object
        public int IngrediantId { get; set; }
        public Ingrediant Ingrediant { get; set; }
        
        //This is the Recipe object
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
        
    }

    /// <summary>
    /// Enumeration of the Measurement Types
    /// </summary>
    public enum MeasurementType
    {
        Cup,
        teaspoon,
        Tablespoon,
        ounce,
        quart,
        gallon,
        pint,
        pounds,
        box

    }
}
