using System;
using BinarySerialization;
using Newtonsoft.Json;

namespace EfsTools.Items.Base
{
    [Serializable]
    
    public class ItemsBase<T> : ItemBase
    {
        public ItemsBase(int itemsCount)
        {
            ItemsCount = itemsCount;
        }

        [JsonIgnore]
        [Ignore]
        public int ItemsCount
        {
            get;
            set;
        }

        [FieldOffset(0)]
        [FieldCount(nameof(ItemsCount))]
        public T[] Value
        {
            get; set;
        }
    }

    public class OneItemsBase<T> : ItemsBase<T>
    {
        public OneItemsBase() : base(1) { }
    }

    public class TwoItemsBase<T> : ItemsBase<T>
    {
        public TwoItemsBase() : base(2) { }
    }

    public class ThreeItemsBase<T> : ItemsBase<T>
    {
        public ThreeItemsBase() : base(3) { }
    }

    public class FourItemsBase<T> : ItemsBase<T>
    {
        public FourItemsBase() : base(4) { }
    }

    public class FiveItemsBase<T> : ItemsBase<T>
    {
        public FiveItemsBase() : base(5) { }
    }

    public class SixItemsBase<T> : ItemsBase<T>
    {
        public SixItemsBase() : base(6) { }
    }

    public class SevenItemsBase<T> : ItemsBase<T>
    {
        public SevenItemsBase() : base(7) { }
    }

    public class EightItemsBase<T> : ItemsBase<T>
    {
        public EightItemsBase() : base(8) { }
    }
    public class NineItemsBase<T> : ItemsBase<T>
    {
        public NineItemsBase() : base(9) { }
    }

    public class TenItemsBase<T> : ItemsBase<T>
    {
        public TenItemsBase() : base(10) { }
    }

    public class TwelveItemsBase<T> : ItemsBase<T>
    {
        public TwelveItemsBase() : base(12) { }
    }
    
    public class SixteenItemsBase<T> : ItemsBase<T>
    {
        public SixteenItemsBase() : base(16) { }
    }

    public class SeventeenItemsBase<T> : ItemsBase<T>
    {
        public SeventeenItemsBase() : base(17) { }
    }

     public class ThirtyItemsBase<T> : ItemsBase<T>
    {
        public ThirtyItemsBase() : base(30) { }
    }


    public class ThirtyTwoItemsBase<T> : ItemsBase<T>
    {
        public ThirtyTwoItemsBase() : base(32) { }
    }

    public class ThirtySevenItemsBase<T> : ItemsBase<T>
    {
        public ThirtySevenItemsBase() : base(37) { }
    }

    public class FortyEightItemsBase<T> : ItemsBase<T>
    {
        public FortyEightItemsBase() : base(48) { }
    }

    public class SixtyItemsBase<T> : ItemsBase<T>
    {
        public SixtyItemsBase() : base(60) { }
    }

    public class SixtyOneItemsBase<T> : ItemsBase<T>
    {
        public SixtyOneItemsBase() : base(61) { }
    }

    public class SixtyFourItemsBase<T> : ItemsBase<T>
    {
        public SixtyFourItemsBase() : base(64) { }
    }

    public class OneHundredTwentyEightItemsBase<T> : ItemsBase<T>
    {
        public OneHundredTwentyEightItemsBase() : base(128) { }
    }

    public class ThreeHundredEightyFourItemsBase<T> : ItemsBase<T>
    {
        public ThreeHundredEightyFourItemsBase() : base(384) { }
    }

    public class OneThousandTwentyFourItemsBase<T> : ItemsBase<T>
    {
        public OneThousandTwentyFourItemsBase() : base(1024) { }
    }

//one thousand twenty four
    public class TwoByteItemBase : TwoItemsBase<byte> { }
    public class TwoSByteItemBase : TwoItemsBase<sbyte> { }
    public class TwoInt16ItemBase : TwoItemsBase<short> { }
    public class TwoUInt16ItemBase : TwoItemsBase<ushort> { }
    public class TwoInt32ItemBase : TwoItemsBase<int> { }
    public class TwoUInt32ItemBase : TwoItemsBase<uint> { }
    public class TwoInt64ItemBase : TwoItemsBase<long> { }
    public class TwoUInt64ItemBase : TwoItemsBase<ulong> { }
    public class ThreeByteItemBase : ThreeItemsBase<byte> { }
    public class ThreeSByteItemBase : ThreeItemsBase<sbyte> { }
    public class ThreeInt16ItemBase : ThreeItemsBase<short> { }
    public class ThreeUInt16ItemBase : ThreeItemsBase<ushort> { }
    public class FourByteItemBase : FourItemsBase<byte> { }
    public class FourSByteItemBase : FourItemsBase<sbyte> { }
    public class FourInt16ItemBase : FourItemsBase<short> { }
    public class FourUInt16ItemBase : FourItemsBase<ushort> { }
    public class FourInt32ItemBase : FourItemsBase<int> { }
    public class FourUInt32ItemBase : FourItemsBase<uint> { }
    public class SixByteItemBase : SixItemsBase<byte> { }
    public class SixSByteItemBase : SixItemsBase<sbyte> { }
    public class SixInt16ItemBase : SixItemsBase<short> { }
    public class SixUInt16ItemBase : SixItemsBase<ushort> { }
    public class SevenByteItemBase : SevenItemsBase<byte> { }
    public class SevenSByteItemBase : SevenItemsBase<sbyte> { }
    public class SevenInt16ItemBase : SevenItemsBase<short> { }
    public class SevenUInt16ItemBase : SevenItemsBase<ushort> { }
    public class EightByteItemBase : EightItemsBase<byte> { }
    public class EightSByteItemBase : EightItemsBase<sbyte> { }
    public class EightInt16ItemBase : EightItemsBase<short> { }
    public class EightUInt16ItemBase : EightItemsBase<ushort> { }
    public class TenByteItemBase : TenItemsBase<byte> { }
    public class TenSByteItemBase : TenItemsBase<sbyte> { }
    public class TenInt16ItemBase : TenItemsBase<short> { }
    public class TenUInt16ItemBase : TenItemsBase<ushort> { }
    public class TwelveByteItemBase : TwelveItemsBase<byte> { }
    public class SixteenByteItemBase : SixteenItemsBase<byte> { }
    public class SixteenSByteItemBase : SixteenItemsBase<sbyte> { }
    public class SixteenInt16ItemBase : SixteenItemsBase<short> { }
    public class SixteenUInt16ItemBase : SixteenItemsBase<ushort> { }
    public class SeventeenInt16ItemBase : SeventeenItemsBase<short> { }
    public class SeventeenUInt16ItemBase : SeventeenItemsBase<ushort> { }
    public class SeventeenInt32ItemBase : SeventeenItemsBase<int> { }
    public class SeventeenUInt32ItemBase : SeventeenItemsBase<uint> { }
    public class ThirtyByteItemBase : ThirtyItemsBase<byte> { }
    public class ThirtySByteItemBase : ThirtyItemsBase<sbyte> { }
    public class ThirtyInt16ItemBase : ThirtyItemsBase<short> { }
    public class ThirtyUInt16ItemBase : ThirtyItemsBase<ushort> { }
    public class ThirtyInt32ItemBase : ThirtyItemsBase<int> { }
    public class ThirtyUInt32ItemBase : ThirtyItemsBase<uint> { }
    public class ThirtyTwoByteItemBase : ThirtyTwoItemsBase<byte> { }
    public class ThirtyTwoSByteItemBase : ThirtyTwoItemsBase<sbyte> { }
    public class ThirtyTwoInt16ItemBase : ThirtyTwoItemsBase<short> { }
    public class ThirtyTwoUInt16ItemBase : ThirtyTwoItemsBase<ushort> { }
    public class ThirtyTwoInt32ItemBase : ThirtyTwoItemsBase<int> { }
    public class ThirtyTwoUInt32ItemBase : ThirtyTwoItemsBase<uint> { }
    public class ThirtySevenByteItemBase : ThirtySevenItemsBase<byte> { }
    public class ThirtySevenSByteItemBase : ThirtySevenItemsBase<sbyte> { }
    public class ThirtySevenInt16ItemBase : ThirtySevenItemsBase<short> { }
    public class ThirtySevenUInt16ItemBase : ThirtySevenItemsBase<ushort> { }
    public class FortyEightByteItemBase : FortyEightItemsBase<byte> { }
    public class FortyEightSByteItemBase : FortyEightItemsBase<sbyte> { }
    public class SixtyByteItemBase : SixtyItemsBase<byte> { }
    public class SixtySByteItemBase : SixtyItemsBase<sbyte> { }
    public class SixtyInt16ItemBase : SixtyItemsBase<short> { }
    public class SixtyUInt16ItemBase : SixtyItemsBase<ushort> { }
    public class SixtyInt32ItemBase : SixtyItemsBase<int> { }
    public class SixtyUInt32ItemBase : SixtyItemsBase<uint> { }
    public class SixtyOneByteItemBase : SixtyOneItemsBase<byte> { }
    public class SixtyFourByteItemBase : SixtyFourItemsBase<byte> { }
    public class SixtyFourSByteItemBase : SixtyFourItemsBase<sbyte> { }
    public class SixtyFourInt16ItemBase : SixtyFourItemsBase<short> { }
    public class SixtyFourUInt16ItemBase : SixtyFourItemsBase<ushort> { }
    public class SixtyFourInt32ItemBase : SixtyFourItemsBase<int> { }
    public class SixtyFourUInt32ItemBase : SixtyFourItemsBase<uint> { }
    public class OneHundredTwentyEightByteItemBase : OneHundredTwentyEightItemsBase<byte> { }
    public class OneHundredTwentyEightSByteItemBase : OneHundredTwentyEightItemsBase<sbyte> { }
    public class OneHundredTwentyEightInt16ItemBase : OneHundredTwentyEightItemsBase<short> { }
    public class OneHundredTwentyEightUInt16ItemBase : OneHundredTwentyEightItemsBase<ushort> { }
    public class OneHundredTwentyEightInt32ItemBase : OneHundredTwentyEightItemsBase<int> { }
    public class OneHundredTwentyEightUInt32ItemBase : OneHundredTwentyEightItemsBase<uint> { }
    public class ThreeHundredEightyFourByteItemBase : ThreeHundredEightyFourItemsBase<byte> { }
    public class ThreeHundredEightyFourSByteItemBase : ThreeHundredEightyFourItemsBase<sbyte> { }
    public class ThreeHundredEightyFourInt16ItemBase : ThreeHundredEightyFourItemsBase<short> { }
    public class ThreeHundredEightyFourUInt16ItemBase : ThreeHundredEightyFourItemsBase<ushort> { }
    public class ThreeHundredEightyFourInt32ItemBase : ThreeHundredEightyFourItemsBase<int> { }
    public class ThreeHundredEightyFourUInt32ItemBase : ThreeHundredEightyFourItemsBase<uint> { }
    public class OneThousandTwentyFourByteItemBase : OneThousandTwentyFourItemsBase<byte> { }
    public class OneThousandTwentyFourSByteItemBase : OneThousandTwentyFourItemsBase<sbyte> { }
    public class OneThousandTwentyFourInt16ItemBase : OneThousandTwentyFourItemsBase<short> { }
    public class OneThousandTwentyFourUInt16ItemBase : OneThousandTwentyFourItemsBase<ushort> { }
    public class OneThousandTwentyFourInt32ItemBase : OneThousandTwentyFourItemsBase<int> { }
    public class OneThousandTwentyFourUInt32ItemBase : OneThousandTwentyFourItemsBase<uint> { }



}