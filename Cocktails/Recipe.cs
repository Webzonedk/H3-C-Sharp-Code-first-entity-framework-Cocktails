using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Recipe : MotherDrink
    {

        #region fields

        private List<Ingredient> ingredients;
        private List<Accessories> accessories;
        private Glass glassType;

        #endregion


        #region properties

        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public List<Accessories> Accessories
        {
            get { return accessories; }
            set { accessories = value; }
        }

        public Glass GlassType
        {
            get { return glassType; }
            set { glassType = value; }
        }

        #endregion

        #region constructors

        public Recipe(string name, List<Ingredient> ingredients, List<Accessories> accessories, Glass glassType) : base(name)
        {
            this.ingredients = ingredients;
            this.accessories = accessories;
            this.glassType = glassType;
        }

        #endregion







    }
}
