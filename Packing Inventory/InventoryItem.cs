using System;
using System.Collections.Generic;
using System.Text;

namespace Packing_Inventory
{
    class InventoryItem
    {
        public float Weight { get; }
        public float Volume { get; }

        public InventoryItem(float weight, float volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }
}
