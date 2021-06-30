using System;
using System.Collections.Generic;
using System.Text;

namespace Vin_Fletcher_s_Arrows
{
    class Arrow
    {
        public ArrowheadType ArrowheadType;
        public FletchingType FletchingType;
        public float ShaftLength;
        public float ArrowheadCost
        {
            get
            {
                switch (ArrowheadType)
                {
                    case ArrowheadType.Unknown:
                        return -1.00F;
                    case ArrowheadType.Steel:
                        return 10.00F;
                    case ArrowheadType.Wood:
                        return 3.00F;
                    case ArrowheadType.Obsidian:
                        return 5.00F;
                    default:
                        return -1.00F;
                }
            }
        }
        
        public float FletchingCost
        {
            get
            {
                switch (FletchingType)
                {
                    case FletchingType.Unknown:
                        return -1.00F;
                    case FletchingType.Plastic:
                        return 10.00F;
                    case FletchingType.TurkeyFeather:
                        return 5.00F;
                    case FletchingType.GooseFeather:
                        return 3.00F;
                    default:
                        return -1.00F;
                }
            }
        }

        public float ShaftCost
        {
            get => 0.05F * ShaftLength;
        }

        public float ArrowCost
        {
            get => ShaftCost + FletchingCost + ArrowheadCost;
        }


        public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float shaftLength)
        {
            ArrowheadType = arrowheadType;
            FletchingType = fletchingType;
            ShaftLength = shaftLength;
        }

        public static Arrow CreateEliteArrow => new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
        public static Arrow CreateBeginnerArrow => new Arrow(ArrowheadType.Wood, FletchingType.GooseFeather, 75);
        public static Arrow CreateMarkmanArrow => new Arrow(ArrowheadType.Steel, FletchingType.GooseFeather, 65);

    }

    enum ArrowheadType
    {
        Unknown,
        Steel,
        Wood,
        Obsidian
    }

    enum FletchingType
    {
        Unknown,
        Plastic,
        TurkeyFeather,
        GooseFeather
    }

    enum ArrowType
    {
        Unknown,
        Elite,
        Marksman,
        Beginner
    }
}
