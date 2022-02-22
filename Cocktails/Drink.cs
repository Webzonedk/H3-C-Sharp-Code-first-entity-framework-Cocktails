using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Drink : MotherDrink
    {

        #region fields

        private Recipe recipe;

        #endregion



        #region properties

        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

        #endregion



        #region constructors

        public Drink()
        {

        }

        #endregion
    }
}
