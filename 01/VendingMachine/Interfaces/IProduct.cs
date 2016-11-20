using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface IProduct
    {
        int GetCostForACola();
        int GetCostForACandy();
        int GetCostForABagOfChips();
        bool Dispense(Products product, int AmountInVendingMachine, out int ProductPrice, out Change change);
    }
}
