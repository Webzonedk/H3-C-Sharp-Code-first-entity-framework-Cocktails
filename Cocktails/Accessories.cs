using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Accessories : MotherDrink
    {

        #region fields

        private int amount;

        #endregion



        #region properties

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        #endregion



        #region constructors

        public Accessories(string name, int amount) : base(name)
        {
            this.amount = amount;
        }

        #endregion
    }
}
