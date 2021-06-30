using System;
using System.Collections.Generic;
using System.Text;

namespace Packing_Inventory
{
    class Pack
    {
        private InventoryItem[] _inventory { get; }
        public int MaximumItemNumberCapacity { get; }
        public float MaximumItemWeightCapacity { get; }
        public float MaximumItemVolumeCapacity { get; }

        public int CurrentItemNumber { get; }
        public float CurrentItemWeight { get; }
        public float CurrentItemVolume { get; }
        public bool Add(InventoryItem item)
        {
            if (CurrentItemNumber <= MaximumItemNumberCapacity || 
                CurrentItemWeight + item.Weight > MaximumItemWeightCapacity || 
                CurrentItemVolume + item.Volume > MaximumItemVolumeCapacity)
            {
                return false;
            }
            else
            {

            }

        }



        public Pack(int maximumItemCapacity, float maximumWeightCapacity, float maximumVolumeCapacity)
        {
            MaximumItemNumberCapacity = maximumItemCapacity;
            MaximumItemWeightCapacity = maximumWeightCapacity;
            MaximumItemVolumeCapacity = maximumVolumeCapacity;
            _inventory = new InventoryItem[maximumItemCapacity];
        }
    }
}
