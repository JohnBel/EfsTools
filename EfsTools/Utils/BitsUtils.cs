using System;


namespace EfsTools.Utils
{
    internal static class BitsUtils
    {
        public static bool GetBitAsBool(byte[] val, int bitIndex)
        {
            if (val == null || val.Length == 0)
            {
                return false;
            }
            var valIndex = bitIndex / 8;
            if (valIndex >= val.Length)
            {
                return false;
            }
            var bitValueIndex = bitIndex - (valIndex * 8);
            var v = val[valIndex];
            return GetBitAsBool(v, bitValueIndex);
        }

        public static byte[] SetBitAsBool(byte[] val, int bitIndex, bool bitValue)
        {
            if (val == null || val.Length == 0)
            {
                return val;
            }
            var valIndex = bitIndex / 8;
            if (valIndex >= val.Length)
            {
                return val;
            }
            var bitValueIndex = bitIndex - (valIndex * 8);
            var v = val[valIndex];
            v = SetBitAsBool(v, bitValueIndex, bitValue);
            val[valIndex] = v;
            return val;
        }

        public static bool GetBitAsBool(byte[] val, int startIndex, int bitIndex)
        {
            if (val == null || val.Length == 0)
            {
                return false;
            }
            var valIndex = (bitIndex / 8) + startIndex;
            if (valIndex >= val.Length)
            {
                return false;
            }
            var bitValueIndex = bitIndex % 8;
            var v = val[valIndex];
            return GetBitAsBool(v, bitValueIndex);
        }

        public static byte[] SetBitAsBool(byte[] val, int startIndex, int bitIndex, bool bitValue)
        {
            if (val == null || val.Length == 0)
            {
                return val;
            }
            var valIndex = (bitIndex / 8) + startIndex;
            if (valIndex >= val.Length)
            {
                return val;
            }
            var bitValueIndex = bitIndex % 8;
            var v = val[valIndex];
            v = SetBitAsBool(v, bitValueIndex, bitValue);
            val[valIndex] = v;
            return val;
        }
        
        public static bool GetBitAsBool(ulong val, int index)
        {
            var v = ((int) (val >> index) & 1);
            return v == 1;
        }

        public static ulong SetBitAsBool(ulong val, int index, bool bitValue)
        {
            var res = val;
            var v = (ulong) 1 << index;
            if (bitValue)
            {
                res |= v;
            }
            else
            {
                res &= ~v;
            }
            return res;
        }

        public static bool GetBitAsBool(uint val, int index)
        {
            return ((int)(val >> index) & 1) == 1;
        }

        public static uint SetBitAsBool(uint val, int index, bool bitValue)
        {
            var res = val;
            var v = (uint) 1 << index;
            if (bitValue)
            {
                res |= v;
            }
            else
            {
                res &= ~v;
            }
            return res;
        }

        public static bool GetBitAsBool(ushort val, int index)
        {
            var v = ((int) (val >> index) & 1);
            return v == 1;
        }
        
        public static ushort SetBitAsBool(ushort val, int index, bool bitValue)
        {
            var res = val;
            var v = (ushort) 1 << index;
            if (bitValue)
            {
                res = (ushort)(res | v);
            }
            else
            {
                res = (ushort)(res & ~v);
            }
            return res;
        }

        public static bool GetBitAsBool(byte val, int index)
        {
            var v = ((int) (val >> index) & 1);
            return v == 1;
        }

        public static byte SetBitAsBool(byte val, int index, bool bitValue)
        {
            var res = val;
            var v = (byte) 1 << index;
            if (bitValue)
            {
                res = (byte)(res | v);
            }
            else
            {
                res = (byte)(res & ~v);
            }
            return res;
        }
    }
}
