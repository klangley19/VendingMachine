﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Change
    {
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }

        #region public Change MakeChange(decimal amount)
        public void MakeChange(decimal amount)
        {
            decimal amountOfChange = amount;

            while (amountOfChange >= 0.25m)
            {
                this.Quarters++;
                amountOfChange -= 0.25m;
            }

            while (amountOfChange >= 0.10m)
            {
                this.Dimes++;
                amountOfChange -= 0.10m;
            }

            while (amountOfChange >= 0.05m)
            {
                this.Nickels++;
                amountOfChange -= 0.05m;
            }

        }
        #endregion

    }
}

