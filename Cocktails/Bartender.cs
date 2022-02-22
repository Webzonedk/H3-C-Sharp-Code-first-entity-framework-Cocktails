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



        //Creating a new drink in DB
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

        //Getting all drinks from DB
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

        //Searching for a specific phrase in the name of drinks
        public List<Drink> SearchDrink(string input)
        {
            using (CocktailContext context = new CocktailContext())
            {
                var result = context.Drinks.Where(drink => drink.Name.Contains(input)).OrderBy(drink => drink.Name).ToList();
                return result;
            }
        }

        //Get all grasses from DB
        public List<Glass> GetGlasses()
        {
            using (CocktailContext context = new CocktailContext())
            {
                var result = (from glass in context.Glasses
                             select glass).ToList();
                return result;
            }
        }

        //Creating a new glass
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
