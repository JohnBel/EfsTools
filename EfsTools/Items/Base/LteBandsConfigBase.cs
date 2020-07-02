using System;
using EfsTools.Utils;

namespace EfsTools.Items.Base
{
    [Serializable]
    public class LteBandsConfigBase
    {
        private ulong _value;

        public bool B1
        {
            get => BitsUtils.GetBitAsBool(_value, 0);
            set => _value = BitsUtils.SetBitAsBool(_value, 0, value);
        }

        public bool B2
        {
            get => BitsUtils.GetBitAsBool(_value, 1);
            set => _value = BitsUtils.SetBitAsBool(_value, 1, value);
        }

        public bool B3
        {
            get => BitsUtils.GetBitAsBool(_value, 2);
            set => _value = BitsUtils.SetBitAsBool(_value, 2, value);
        }

        public bool B4
        {
            get => BitsUtils.GetBitAsBool(_value, 3);
            set => _value = BitsUtils.SetBitAsBool(_value, 3, value);
        }

        public bool B5
        {
            get => BitsUtils.GetBitAsBool(_value, 4);
            set => _value = BitsUtils.SetBitAsBool(_value, 4, value);
        }

        public bool B6
        {
            get => BitsUtils.GetBitAsBool(_value, 5);
            set => _value = BitsUtils.SetBitAsBool(_value, 5, value);
        }

        public bool B7
        {
            get => BitsUtils.GetBitAsBool(_value, 6);
            set => _value = BitsUtils.SetBitAsBool(_value, 6, value);
        }

        public bool B8
        {
            get => BitsUtils.GetBitAsBool(_value, 7);
            set => _value = BitsUtils.SetBitAsBool(_value, 7, value);
        }

        public bool B9
        {
            get => BitsUtils.GetBitAsBool(_value, 8);
            set => _value = BitsUtils.SetBitAsBool(_value, 8, value);
        }

        public bool B10
        {
            get => BitsUtils.GetBitAsBool(_value, 9);
            set => _value = BitsUtils.SetBitAsBool(_value, 9, value);
        }

        public bool B11
        {
            get => BitsUtils.GetBitAsBool(_value, 10);
            set => _value = BitsUtils.SetBitAsBool(_value, 10, value);
        }

        public bool B12
        {
            get => BitsUtils.GetBitAsBool(_value, 11);
            set => _value = BitsUtils.SetBitAsBool(_value, 11, value);
        }

        public bool B13
        {
            get => BitsUtils.GetBitAsBool(_value, 12);
            set => _value = BitsUtils.SetBitAsBool(_value, 12, value);
        }

        public bool B14
        {
            get => BitsUtils.GetBitAsBool(_value, 13);
            set => _value = BitsUtils.SetBitAsBool(_value, 13, value);
        }

        public bool B15
        {
            get => BitsUtils.GetBitAsBool(_value, 14);
            set => _value = BitsUtils.SetBitAsBool(_value, 14, value);
        }

        public bool B16
        {
            get => BitsUtils.GetBitAsBool(_value, 15);
            set => _value = BitsUtils.SetBitAsBool(_value, 15, value);
        }

        public bool B17
        {
            get => BitsUtils.GetBitAsBool(_value, 16);
            set => _value = BitsUtils.SetBitAsBool(_value, 16, value);
        }

        public bool B18
        {
            get => BitsUtils.GetBitAsBool(_value, 17);
            set => _value = BitsUtils.SetBitAsBool(_value, 17, value);
        }

        public bool B19
        {
            get => BitsUtils.GetBitAsBool(_value, 18);
            set => _value = BitsUtils.SetBitAsBool(_value, 18, value);
        }

        public bool B20
        {
            get => BitsUtils.GetBitAsBool(_value, 19);
            set => _value = BitsUtils.SetBitAsBool(_value, 19, value);
        }

        public bool B21
        {
            get => BitsUtils.GetBitAsBool(_value, 20);
            set => _value = BitsUtils.SetBitAsBool(_value, 20, value);
        }

        public bool B22
        {
            get => BitsUtils.GetBitAsBool(_value, 21);
            set => _value = BitsUtils.SetBitAsBool(_value, 21, value);
        }

        public bool B23
        {
            get => BitsUtils.GetBitAsBool(_value, 22);
            set => _value = BitsUtils.SetBitAsBool(_value, 22, value);
        }

        public bool B24
        {
            get => BitsUtils.GetBitAsBool(_value, 23);
            set => _value = BitsUtils.SetBitAsBool(_value, 23, value);
        }

        public bool B25
        {
            get => BitsUtils.GetBitAsBool(_value, 24);
            set => _value = BitsUtils.SetBitAsBool(_value, 24, value);
        }

        public bool B26
        {
            get => BitsUtils.GetBitAsBool(_value, 25);
            set => _value = BitsUtils.SetBitAsBool(_value, 25, value);
        }

        public bool B27
        {
            get => BitsUtils.GetBitAsBool(_value, 26);
            set => _value = BitsUtils.SetBitAsBool(_value, 26, value);
        }

        public bool B28
        {
            get => BitsUtils.GetBitAsBool(_value, 27);
            set => _value = BitsUtils.SetBitAsBool(_value, 27, value);
        }

        public bool B29
        {
            get => BitsUtils.GetBitAsBool(_value, 28);
            set => _value = BitsUtils.SetBitAsBool(_value, 28, value);
        }

        public bool B30
        {
            get => BitsUtils.GetBitAsBool(_value, 29);
            set => _value = BitsUtils.SetBitAsBool(_value, 29, value);
        }

        public bool B31
        {
            get => BitsUtils.GetBitAsBool(_value, 30);
            set => _value = BitsUtils.SetBitAsBool(_value, 30, value);
        }

        public bool B32
        {
            get => BitsUtils.GetBitAsBool(_value, 31);
            set => _value = BitsUtils.SetBitAsBool(_value, 31, value);
        }

        public bool B33
        {
            get => BitsUtils.GetBitAsBool(_value, 32);
            set => _value = BitsUtils.SetBitAsBool(_value, 32, value);
        }

        public bool B34
        {
            get => BitsUtils.GetBitAsBool(_value, 33);
            set => _value = BitsUtils.SetBitAsBool(_value, 33, value);
        }

        public bool B35
        {
            get => BitsUtils.GetBitAsBool(_value, 34);
            set => _value = BitsUtils.SetBitAsBool(_value, 34, value);
        }

        public bool B36
        {
            get => BitsUtils.GetBitAsBool(_value, 35);
            set => _value = BitsUtils.SetBitAsBool(_value, 35, value);
        }

        public bool B37
        {
            get => BitsUtils.GetBitAsBool(_value, 36);
            set => _value = BitsUtils.SetBitAsBool(_value, 36, value);
        }

        public bool B38
        {
            get => BitsUtils.GetBitAsBool(_value, 37);
            set => _value = BitsUtils.SetBitAsBool(_value, 37, value);
        }

        public bool B39
        {
            get => BitsUtils.GetBitAsBool(_value, 38);
            set => _value = BitsUtils.SetBitAsBool(_value, 38, value);
        }

        public bool B40
        {
            get => BitsUtils.GetBitAsBool(_value, 39);
            set => _value = BitsUtils.SetBitAsBool(_value, 39, value);
        }

        public bool B41
        {
            get => BitsUtils.GetBitAsBool(_value, 40);
            set => _value = BitsUtils.SetBitAsBool(_value, 40, value);
        }

        public bool B42
        {
            get => BitsUtils.GetBitAsBool(_value, 41);
            set => _value = BitsUtils.SetBitAsBool(_value, 41, value);
        }

        public bool B43
        {
            get => BitsUtils.GetBitAsBool(_value, 42);
            set => _value = BitsUtils.SetBitAsBool(_value, 42, value);
        }

        public bool B44
        {
            get => BitsUtils.GetBitAsBool(_value, 43);
            set => _value = BitsUtils.SetBitAsBool(_value, 43, value);
        }
    }
}
