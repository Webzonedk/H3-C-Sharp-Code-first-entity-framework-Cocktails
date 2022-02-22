using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Bartender
    {
        #region fields

        #endregion



        #region properties

        #endregion



        #region constructors

        public Bartender()
        {

        }

        #endregion




        public void CreateDrink(Drink drink)
        {
            using (CocktailContext context = new CocktailContext())
            {
                context.Drinks.Add(drink);
                context.SaveChanges();
            }
        }

        public void EditDrink()
        {

        }

        public void DeleteDrink()
        {

        }

        public List<Drink> ListAllDrinks()
        {
            using (CocktailContext context = new CocktailContext())
            {
                var result = context.Drinks.OrderBy(drink => drink.Name).ToList();
                //var result = (from drink in context.Drinks
                //             select drink).ToList();

                return result;
            }

        }

        public void SearchDrink(string input)
        {
            using (CocktailContext context = new CocktailContext())
            {
                var result = from ingredient in context.Ingredients
                             where ingredient.Name.Contains(input)
                             select ingredient;

                foreach (Ingredient ingredient in result)
                {
                    Console.WriteLine(ingredient.Name);
                }
            }

        }

        public List<Glass> GetGlasses()
        {
            using (CocktailContext context = new CocktailContext())
            {
                var result = (from glass in context.Glasses
                             select glass).ToList();

                return result;
            }
        }

        public void CreateGlass(string glassName)
        {
            using (CocktailContext context = new CocktailContext())
            {
                Glass glass = new Glass() { Name = glassName };

                context.Glasses.Add(glass);
                context.SaveChanges();

            }
        }
    }
}
