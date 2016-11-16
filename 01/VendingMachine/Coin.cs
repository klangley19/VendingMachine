using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public static class Coin
    {
        #region public static int GetValueForNickel()
        public static int GetValueForNickel()
        {
            return 5;
        }
        #endregion

        #region public static int GetValueForDime()
        public static int GetValueForDime()
        {
            return 10;
        }
        #endregion

        #region public static int GetValueForQuarter()
        public static int GetValueForQuarter()
        {
            return 25;
        }
        #endregion

    }
}
