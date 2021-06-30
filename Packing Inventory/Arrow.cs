using System;
using System.Collections.Generic;
using System.Text;

namespace Packing_Inventory
{
    class Arrow : InventoryItem
    {
        public Arrow() : base(0.1F, 0.05F)
        {
        }

        public override string ToString() => "Rope";
    }
}
