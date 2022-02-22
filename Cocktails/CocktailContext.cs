using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Cocktails
{
    class CocktailContext:DbContext
    {

        public CocktailContext() : base("name=cocktailDBConnectionString")
        {
            Database.SetInitializer<CocktailContext>(new CreateDatabaseIfNotExists<CocktailContext>());
        }


        public DbSet<Ingredient> Ingredients { get; set; }

         


    }
}
