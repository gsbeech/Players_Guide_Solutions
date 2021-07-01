using System;
using System.Collections.Generic;
using System.Text;

namespace Packing_Inventory
{
    class Food : InventoryItem
    {
        public Food() : base(1F, 0.5F)
        {
        }
        public override string ToString() => "Food";
    }
}
