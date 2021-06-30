using System;
using System.Collections.Generic;
using System.Text;

namespace Packing_Inventory
{
    class Bow : InventoryItem
    {
        public Bow() : base(1F, 4F)
        {
        }
        public override string ToString() => "Bow";
    }
}
