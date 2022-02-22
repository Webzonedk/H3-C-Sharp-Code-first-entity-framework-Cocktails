using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cocktails
{
    class CocktailDBInitializer : DropCreateDatabaseIfModelChanges<CocktailContext>
    {


        protected override void Seed(CocktailContext context)
        {
            IList<Glass> glasses = new List<Glass>();



            glasses.Add(new Glass() { Name = "Champagne glass" });
            glasses.Add(new Glass() { Name = "Burgundy glass" });
            glasses.Add(new Glass() { Name = "Bordeaux glass" });
            glasses.Add(new Glass() { Name = "Whisky glass" });
            glasses.Add(new Glass() { Name = "Longdrink glass" });

            context.Glasses.AddRange(glasses);


         



            base.Seed(context);
        }

    }
}
