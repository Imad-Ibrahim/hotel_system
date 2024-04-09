using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Recipe : IRecipe
    {
        public int recipeID { get; set; }
        public string name { get; set; }
        public List<IStockItem> ingredients { get; set; }
        public string instructions { get; set; }
        public int estimatedMinutesToPrepare { get; set; }
        public string[] allergens { get; set; }
        public Recipe()
        {
            this.recipeID = 0;
            this.name = "";
            this.ingredients = new List<IStockItem>();
            this.instructions = "";
            this.estimatedMinutesToPrepare = 0;
            string[] all = new string[10];
            this.allergens = all;
        }
        public Recipe(int recipeID, string name, List<IStockItem> ingredients, string instructions, int estimatedMinutesToPrepare, string[] allergens)
        {
            this.recipeID = recipeID;
            this.name = name;
            this.ingredients = ingredients;
            this.instructions = instructions;
            this.estimatedMinutesToPrepare = estimatedMinutesToPrepare;
            this.allergens = allergens;
        }
    }
}
