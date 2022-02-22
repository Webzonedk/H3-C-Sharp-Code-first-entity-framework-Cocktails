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
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------   Welcome to the cocktail database. How can I help You?   ----------------------------------");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" | 1: Search drink | 2: print list of all drinks | 3: create new drink | 4: Edit existing drink | 5: Delete drink | 9: Exit | ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
                //Creating an instanse of bartender to be able to use the methods within the class
                Bartender bartender = new Bartender();
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        //Searching for all drinks conrtaining this phrase
                        Console.WriteLine("Type the search phrase");
                        string phrase = Console.ReadLine();
                        List<Drink> drinks = bartender.SearchDrink(phrase);
                        break;
                    case '2':

                        break;
                    case '3':
                        Console.WriteLine("Please name the drink?");
                        string name = Console.ReadLine();
                        Recipe recipe = new Recipe();
                        List<Glass> glasses = bartender.GetGlasses();


                        ////Choosing a glass type
                        if (glasses.Count > 0)
                        {
                            Console.WriteLine("Please Choose a glass from the list:");
                            for (int i = 0; i < glasses.Count; i++)
                            {
                                Console.WriteLine($"{glasses[i].Id}: {glasses[i].Name}");
                            }
                            //Getting the nummeric value from the char
                            double key = (Char.GetNumericValue(Console.ReadKey(true).KeyChar));
                            bool foundMatch = false;
                            for (int i = 0; i < glasses.Count; i++)
                            {
                                if (i == key-1)
                                {
                                    recipe.GlassType = glasses[i];
                                    i = glasses.Count;
                                    foundMatch = true;
                                }
                            }
                            if (foundMatch==false)
                            {
                                Console.WriteLine("The glass was not found in the database, please create one");
                                string glassName = Console.ReadLine();
                                Glass glass = new Glass() { Name = glassName };
                                recipe.GlassType = glass;
                                bartender.CreateGlass(glassName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is no glasses in the database, please create one");
                            string glassName = Console.ReadLine();
                            Glass glass = new Glass() { Name = glassName };
                            recipe.GlassType = glass;
                            bartender.CreateGlass(glassName);
                        }
                        Console.WriteLine($"the glass {recipe.GlassType.Name} has been selected");
                        Console.WriteLine();


                        //Asking to add ingredients
                        Console.WriteLine("How many ingredients do you wish to add? (0-9)");
                        double ingredients = (Char.GetNumericValue(Console.ReadKey(true).KeyChar));
                        for (int i = 0; i < ingredients; i++)
                        {
                            Console.WriteLine("Please add ingredient");
                        }



                        //Asking to add accessories



                        //Not yet in use
                        Drink drink = new Drink();
                        //bartender.CreateDrink(drink);

                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '9':
                        exit = true;
                        break;


                }

            }

            Console.ReadKey();

        }
    }
}
