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
            //Database.SetInitializer<CocktailContext>(new CreateDatabaseIfNotExists<CocktailContext>());
            Database.SetInitializer<CocktailContext>(new DropCreateDatabaseIfModelChanges<CocktailContext>());
            //Database.SetInitializer<CocktailContext>(new DropCreateDatabaseAlways<CocktailContext>());
            //Database.SetInitializer<CocktailContext>(new CocktailContext());
        }


        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<Glass> Glasses { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Drink> Drinks { get; set; }

         


    }
}
