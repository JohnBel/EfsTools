using System;
using BinarySerialization;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Base
{
    [Serializable]
    public class LteBandsConfigBase
    {
        [FieldOrder(0)]
        [JsonIgnore]
        public ulong Value { get; set; }

        [Ignore]
        public bool B1
        {
            get => BitsUtils.GetBitAsBool(Value, 0);
            set => Value = BitsUtils.SetBitAsBool(Value, 0, value);
        }

        [Ignore]
        public bool B2
        {
            get => BitsUtils.GetBitAsBool(Value, 1);
            set => Value = BitsUtils.SetBitAsBool(Value, 1, value);
        }

        [Ignore]
        public bool B3
        {
            get => BitsUtils.GetBitAsBool(Value, 2);
            set => Value = BitsUtils.SetBitAsBool(Value, 2, value);
        }

        [Ignore]
        public bool B4
        {
            get => BitsUtils.GetBitAsBool(Value, 3);
            set => Value = BitsUtils.SetBitAsBool(Value, 3, value);
        }

        [Ignore]
        public bool B5
        {
            get => BitsUtils.GetBitAsBool(Value, 4);
            set => Value = BitsUtils.SetBitAsBool(Value, 4, value);
        }

        [Ignore]
        public bool B6
        {
            get => BitsUtils.GetBitAsBool(Value, 5);
            set => Value = BitsUtils.SetBitAsBool(Value, 5, value);
        }

        [Ignore]
        public bool B7
        {
            get => BitsUtils.GetBitAsBool(Value, 6);
            set => Value = BitsUtils.SetBitAsBool(Value, 6, value);
        }

        [Ignore]
        public bool B8
        {
            get => BitsUtils.GetBitAsBool(Value, 7);
            set => Value = BitsUtils.SetBitAsBool(Value, 7, value);
        }

        [Ignore]
        public bool B9
        {
            get => BitsUtils.GetBitAsBool(Value, 8);
            set => Value = BitsUtils.SetBitAsBool(Value, 8, value);
        }

        [Ignore]
        public bool B10
        {
            get => BitsUtils.GetBitAsBool(Value, 9);
            set => Value = BitsUtils.SetBitAsBool(Value, 9, value);
        }

        [Ignore]
        public bool B11
        {
            get => BitsUtils.GetBitAsBool(Value, 10);
            set => Value = BitsUtils.SetBitAsBool(Value, 10, value);
        }

        [Ignore]
        public bool B12
        {
            get => BitsUtils.GetBitAsBool(Value, 11);
            set => Value = BitsUtils.SetBitAsBool(Value, 11, value);
        }

        [Ignore]
        public bool B13
        {
            get => BitsUtils.GetBitAsBool(Value, 12);
            set => Value = BitsUtils.SetBitAsBool(Value, 12, value);
        }

        [Ignore]
        public bool B14
        {
            get => BitsUtils.GetBitAsBool(Value, 13);
            set => Value = BitsUtils.SetBitAsBool(Value, 13, value);
        }

        [Ignore]
        public bool B15
        {
            get => BitsUtils.GetBitAsBool(Value, 14);
            set => Value = BitsUtils.SetBitAsBool(Value, 14, value);
        }
        
        [Ignore]
        public bool B16
        {
            get => BitsUtils.GetBitAsBool(Value, 15);
            set => Value = BitsUtils.SetBitAsBool(Value, 15, value);
        }

        [Ignore]
        public bool B17
        {
            get => BitsUtils.GetBitAsBool(Value, 16);
            set => Value = BitsUtils.SetBitAsBool(Value, 16, value);
        }

        [Ignore]
        public bool B18
        {
            get => BitsUtils.GetBitAsBool(Value, 17);
            set => Value = BitsUtils.SetBitAsBool(Value, 17, value);
        }

        [Ignore]
        public bool B19
        {
            get => BitsUtils.GetBitAsBool(Value, 18);
            set => Value = BitsUtils.SetBitAsBool(Value, 18, value);
        }

        [Ignore]
        public bool B20
        {
            get => BitsUtils.GetBitAsBool(Value, 19);
            set => Value = BitsUtils.SetBitAsBool(Value, 19, value);
        }

        [Ignore]
        public bool B21
        {
            get => BitsUtils.GetBitAsBool(Value, 20);
            set => Value = BitsUtils.SetBitAsBool(Value, 20, value);
        }

        [Ignore]
        public bool B22
        {
            get => BitsUtils.GetBitAsBool(Value, 21);
            set => Value = BitsUtils.SetBitAsBool(Value, 21, value);
        }

        [Ignore]
        public bool B23
        {
            get => BitsUtils.GetBitAsBool(Value, 22);
            set => Value = BitsUtils.SetBitAsBool(Value, 22, value);
        }

        [Ignore]
        public bool B24
        {
            get => BitsUtils.GetBitAsBool(Value, 23);
            set => Value = BitsUtils.SetBitAsBool(Value, 23, value);
        }

        [Ignore]
        public bool B25
        {
            get => BitsUtils.GetBitAsBool(Value, 24);
            set => Value = BitsUtils.SetBitAsBool(Value, 24, value);
        }

        [Ignore]
        public bool B26
        {
            get => BitsUtils.GetBitAsBool(Value, 25);
            set => Value = BitsUtils.SetBitAsBool(Value, 25, value);
        }

        [Ignore]
        public bool B27
        {
            get => BitsUtils.GetBitAsBool(Value, 26);
            set => Value = BitsUtils.SetBitAsBool(Value, 26, value);
        }

        [Ignore]
        public bool B28
        {
            get => BitsUtils.GetBitAsBool(Value, 27);
            set => Value = BitsUtils.SetBitAsBool(Value, 27, value);
        }

        [Ignore]
        public bool B29
        {
            get => BitsUtils.GetBitAsBool(Value, 28);
            set => Value = BitsUtils.SetBitAsBool(Value, 28, value);
        }

        [Ignore]
        public bool B30
        {
            get => BitsUtils.GetBitAsBool(Value, 29);
            set => Value = BitsUtils.SetBitAsBool(Value, 29, value);
        }

        [Ignore]
        public bool B31
        {
            get => BitsUtils.GetBitAsBool(Value, 30);
            set => Value = BitsUtils.SetBitAsBool(Value, 30, value);
        }

        [Ignore]
        public bool B32
        {
            get => BitsUtils.GetBitAsBool(Value, 31);
            set => Value = BitsUtils.SetBitAsBool(Value, 31, value);
        }

        [Ignore]
        public bool B33
        {
            get => BitsUtils.GetBitAsBool(Value, 32);
            set => Value = BitsUtils.SetBitAsBool(Value, 32, value);
        }

        [Ignore]
        public bool B34
        {
            get => BitsUtils.GetBitAsBool(Value, 33);
            set => Value = BitsUtils.SetBitAsBool(Value, 33, value);
        }

        [Ignore]
        public bool B35
        {
            get => BitsUtils.GetBitAsBool(Value, 34);
            set => Value = BitsUtils.SetBitAsBool(Value, 34, value);
        }

        [Ignore]
        public bool B36
        {
            get => BitsUtils.GetBitAsBool(Value, 35);
            set => Value = BitsUtils.SetBitAsBool(Value, 35, value);
        }

        [Ignore]
        public bool B37
        {
            get => BitsUtils.GetBitAsBool(Value, 36);
            set => Value = BitsUtils.SetBitAsBool(Value, 36, value);
        }

        [Ignore]
        public bool B38
        {
            get => BitsUtils.GetBitAsBool(Value, 37);
            set => Value = BitsUtils.SetBitAsBool(Value, 37, value);
        }

        [Ignore]
        public bool B39
        {
            get => BitsUtils.GetBitAsBool(Value, 38);
            set => Value = BitsUtils.SetBitAsBool(Value, 38, value);
        }

        [Ignore]
        public bool B40
        {
            get => BitsUtils.GetBitAsBool(Value, 39);
            set => Value = BitsUtils.SetBitAsBool(Value, 39, value);
        }

        [Ignore]
        public bool B41
        {
            get => BitsUtils.GetBitAsBool(Value, 40);
            set => Value = BitsUtils.SetBitAsBool(Value, 40, value);
        }

        [Ignore]
        public bool B42
        {
            get => BitsUtils.GetBitAsBool(Value, 41);
            set => Value = BitsUtils.SetBitAsBool(Value, 41, value);
        }

        [Ignore]
        public bool B43
        {
            get => BitsUtils.GetBitAsBool(Value, 42);
            set => Value = BitsUtils.SetBitAsBool(Value, 42, value);
        }

        [Ignore]
        public bool B44
        {
            get => BitsUtils.GetBitAsBool(Value, 43);
            set => Value = BitsUtils.SetBitAsBool(Value, 43, value);
        }

        [Ignore]
        public bool B45
        {
            get => BitsUtils.GetBitAsBool(Value, 44);
            set => Value = BitsUtils.SetBitAsBool(Value, 44, value);
        }

        [Ignore]
        public bool B46
        {
            get => BitsUtils.GetBitAsBool(Value, 45);
            set => Value = BitsUtils.SetBitAsBool(Value, 45, value);
        }
        
        [Ignore]
        public bool B47
        {
            get => BitsUtils.GetBitAsBool(Value, 46);
            set => Value = BitsUtils.SetBitAsBool(Value, 46, value);
        }

        [Ignore]
        public bool B48
        {
            get => BitsUtils.GetBitAsBool(Value, 47);
            set => Value = BitsUtils.SetBitAsBool(Value, 47, value);
        }
    }
}
