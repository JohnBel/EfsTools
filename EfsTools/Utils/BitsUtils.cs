using System;


namespace EfsTools.Utils
{
    internal static class BitsUtils
    {
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
            return ((int)(val >> index) & 1) == 1;
        }

        public static ushort SetBitAsBool(ushort val, int index, bool bitValue)
        {
            var res = val;
            var v = (ushort) 1 << index;
            if (bitValue)
            {
                res = (ushort)(v | res);
            }
            else
            {
                res = (ushort)((~v) & res);
            }
            return res;
        }
    }
}
