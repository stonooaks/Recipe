using Hughes.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipe.Data
{
    /// <summary>
    /// This is the model for Ingredient object
    /// </summary>
    public class Ingrediant : EntityData
    {
        public string Name { get; set; }
        public Department Department { get; set; }
    }

    /// <summary>
    /// This is the enumeration for the Grocery Department
    /// </summary>
    public enum Department
    {
        Produce,
        DryGoods,
        Meats,
        Soups,
        Bread,
        Frozen,
        Dairy,
        Pet

    }
}
