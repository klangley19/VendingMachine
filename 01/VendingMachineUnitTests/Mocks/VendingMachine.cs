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
        bool DepositCoin(int CoinSize, int CoinWeight);
        int GetVendingMachineCoinValueInCents();
        string GetVendingMachineDisplay();
        bool Dispense(Products product);
        Change LatestChangeMade();
        Change GetChangeInVendingMachine();
        bool ReturnChangeInVendingMachine();
        Inventory GetInventoryLevels();
        void SetInventoryLevels(Inventory i);
        void SetExactChange(bool setting);
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

        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            return this._dependency.DepositCoin(CoinSize, CoinWeight);
        }

        public int GetVendingMachineCoinValueInCents()
        {
            return this._dependency.GetVendingMachineCoinValueInCents();
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

        public Change GetChangeInVendingMachine()
        {
            return this._dependency.GetChangeInVendingMachine();
        }

        public bool ReturnChangeInVendingMachine()
        {
            return this._dependency.ReturnChangeInVendingMachine();
        }

        public Inventory GetInventoryLevels()
        {
            return this._dependency.GetInventoryLevels();
        }

        public void SetInventoryLevels(Inventory i)
        {
            this._dependency.SetInventoryLevels(i);
        }

        public void SetExactChange(bool setting)
        {
            this._dependency.SetExactChange(setting);
        }

    }
    #endregion

    #region public class MockVendingMachineDependency : IVendingMachineDependency
    public class MockVendingMachineDependency : IVendingMachineDependency
    {
        public MockVendingMachineDependency()
        {
            ICoin Coin = new Coin();
            IProduct Product = new Product();
            machine = new VendingMachine.VendingMachine(Coin, Product);
            this.Coin = Coin as Coin;
        }

        private Coin Coin;
        private VendingMachine.VendingMachine machine;

        public bool AddNickelToVendingMachine()
        {
            return machine.DepositCoin(this.Coin.GetSizeForNickel(), this.Coin.GetWeightForNickel());
        }

        public bool AddDimeToVendingMachine()
        {
            return machine.DepositCoin(this.Coin.GetSizeForDime(), this.Coin.GetWeightForDime());
        }

        public bool AddQuarterToVendingMachine()
        {
            return machine.DepositCoin(this.Coin.GetSizeForQuarter(), this.Coin.GetWeightForQuarter());
        }

        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            return machine.DepositCoin(CoinSize, CoinWeight);
        }

        public int GetVendingMachineCoinValueInCents()
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

        public Change GetChangeInVendingMachine()
        {
            return machine.ChangeInVendingMachine;
        }

        public bool ReturnChangeInVendingMachine()
        {
            return machine.ReturnChangeInVendingMachine();
        }

        public Inventory GetInventoryLevels()
        {
            return machine.InventoryInVendingMachine;
        }

        public void SetInventoryLevels(Inventory i)
        {
            machine.InventoryInVendingMachine = i;
        }

        public void SetExactChange(bool setting)
        {
            machine.RequireExactChangeForPurchase = setting;
        }

        #endregion


    }
}
