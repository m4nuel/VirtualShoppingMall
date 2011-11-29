using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualShoppingMall.Views.Business_Account.InventoryEditor
{
    internal class InventoryData
    {
        public InventoryData() { }

        public string Name { get; set; }
        public int Count { get; set; }
        public int Minimum { get; set; }
        public bool IsInventoryLow
        {
            get
            {
                return Count <= Minimum;
            }

            set
            {
                
            }
        }
    }
}
