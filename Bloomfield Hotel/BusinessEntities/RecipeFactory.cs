using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RecipeFactory
    {
        private static IRecipe recipe = null;
        public static IRecipe GetRecipe(int recipeID, string name, List<IStockItem> ingredients, string instructions, int estimatedMinutesToPrepare, string[] allergens)
        {
            return new Recipe(recipeID, name, ingredients, instructions, estimatedMinutesToPrepare, allergens);
        }
        public static void SetRecipe(IRecipe aRecipe)
        {
            recipe = aRecipe;
        }
    }
}
