using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            //using(CocktailContext context = new CocktailContext())
            //{
            //    Ingredient ingredient = new Ingredient() { name = "Vodka" };

            //    context.Ingredients.Add(ingredient);
            //    context.SaveChanges();

            //}


            using (CocktailContext context = new CocktailContext())
            {
                var result = from ingredient in context.Ingredients
                             where ingredient.Name.Contains("vod")
                             select ingredient;

                foreach (Ingredient drink in result)
                {
                    Console.WriteLine(drink.Name);
                }
            }

            Console.WriteLine("completed");
            Console.ReadLine();


        }
    }
}
