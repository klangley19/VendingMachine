using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VendingMachine;


namespace VendingMachineUnitTests.Mocks
{

    #region public interface IVendingMachineDependency
    public interface IVendingMachineDependency
    {
        bool AddNickelToVendingMachine();
        bool AddDimeToVendingMachine();
        bool AddQuarterToVendingMachine();
        int GetVendingMachineCoinValueInPennies();
        string GetVendingMachineDisplay();
        bool Dispense(Products product);
        Change LatestChangeMade();
    }
    #endregion

    #region public class VendingMachineDependentClass
    public class VendingMachineDependentClass
    {
        private readonly IVendingMachineDependency _dependency;

        public VendingMachineDependentClass(IVendingMachineDependency dependency)
        {
            this._dependency = dependency;
        }

        public bool AddNickelToVendingMachine()
        {
            return this._dependency.AddNickelToVendingMachine();
        }

        public bool AddDimeToVendingMachine()
        {
            return this._dependency.AddDimeToVendingMachine();
        }

        public bool AddQuarterToVendingMachine()
        {
            return this._dependency.AddQuarterToVendingMachine();
        }

        public int GetVendingMachineCoinValueInPennies()
        {
            return this._dependency.GetVendingMachineCoinValueInPennies();
        }

        public string GetVendingMachineDisplay()
        {
            return this._dependency.GetVendingMachineDisplay();
        }

        public bool Dispense(Products product)
        {
            return this._dependency.Dispense(product);
        }

        public Change LatestChangeMade()
        {
            return this._dependency.LatestChangeMade();
        }

    }
    #endregion

    #region public class MockVendingMachineDependency : IVendingMachineDependency
    public class MockVendingMachineDependency : IVendingMachineDependency
    {
        private VendingMachine.VendingMachine machine = new VendingMachine.VendingMachine();

        public bool AddNickelToVendingMachine()
        {
            return machine.DepositCoin(Coin.GetSizeForNickel(), Coin.GetWeightForNickel());
        }

        public bool AddDimeToVendingMachine()
        {
            return machine.DepositCoin(Coin.GetSizeForDime(), Coin.GetWeightForDime());
        }

        public bool AddQuarterToVendingMachine()
        {
            return machine.DepositCoin(Coin.GetSizeForQuarter(), Coin.GetWeightForQuarter());
        }

        public int GetVendingMachineCoinValueInPennies()
        {
            return machine.DepositedValueInMachine;
        }

        public string GetVendingMachineDisplay()
        {
            return machine.Display;
        }

        public bool Dispense(Products product)
        {
            return machine.Dispense(product);
        }

        public Change LatestChangeMade()
        {
            return machine.LatestChangeMade;
        }
        #endregion


    }
}
