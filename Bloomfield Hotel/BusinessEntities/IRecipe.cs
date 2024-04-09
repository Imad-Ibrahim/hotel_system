using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IRecipe
    {
        int recipeID { get; set; }
        string name { get; set; }
        List<IStockItem> ingredients { get; set; }
        string instructions { get; set; }
        int estimatedMinutesToPrepare { get; set; }
        string[] allergens { get; set; }
    }
}
