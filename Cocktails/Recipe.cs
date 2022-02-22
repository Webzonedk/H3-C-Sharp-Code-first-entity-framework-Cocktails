using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Recipe:MotherDrink
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

        public Recipe()
        {
            this.ingredients = new List<Ingredient>();
            this.accessories = new List<Accessories>();
        }

        #endregion







    }
}
