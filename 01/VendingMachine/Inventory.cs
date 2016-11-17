using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Inventory
    {
        private int _candyQuantity = 100;
        private int _chipQuantity = 100;
        private int _colaQuantity = 100;


        public int CandyQuantity
        {
            get { return this._candyQuantity; }
            set { this._candyQuantity = value; }
        }

        public int ChipQuantity
        {
            get { return this._chipQuantity; }
            set { this._chipQuantity = value; }
        }

        public int ColaQuantity
        {
            get { return this._colaQuantity; }
            set { this._colaQuantity = value; }
        }



    }
}
