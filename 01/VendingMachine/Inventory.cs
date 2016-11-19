using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{


    public class Inventory
    {
        private const int InitialCandyInventory = 100;
        private const int InitialChipInventory = 100;
        private const int InitialColaInventory = 100;

        private int _candyQuantity = InitialCandyInventory;
        private int _chipQuantity = InitialChipInventory;
        private int _colaQuantity = InitialColaInventory;


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
