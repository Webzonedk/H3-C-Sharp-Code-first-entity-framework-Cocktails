using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class MotherDrink
    {

        #region fields

        private int id;

        private string name;

        #endregion


        #region properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region constructors
        public MotherDrink(string name)
        {
            this.name = name;
        }
        #endregion

    }
}
