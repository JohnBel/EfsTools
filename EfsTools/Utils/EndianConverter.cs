namespace EfsTools.Utils
{
    internal static class EndianConverter
    {
        public static short Convert(short val)
        {
            var tmp = (ushort) val;
            var v1 = (tmp & 0xFF) << 8;
            var v2 = (tmp & 0xFF00) >> 8;
            var v = v1 | v2;
            return (short) v;
        }

        public static int Convert(int val)
        {
            var tmp = (uint) val;
            var v1 = (tmp & 0xFF) << 24;
            var v2 = (tmp & 0xFF00) << 8;
            var v3 = (tmp & 0xFF0000) >> 8;
            var v4 = (tmp & 0xFF000000) >> 24;
            var v = v1 | v2 | v3 | v4;
            return (int) v;
        }

        public static long Convert(long val)
        {
            var tmp = (ulong) val;
            var v1 = (tmp & 0xFF) << 56;
            var v2 = (tmp & 0xFF00) << 40;
            var v3 = (tmp & 0xFF0000) << 24;
            var v4 = (tmp & 0xFF000000) << 8;
            var v5 = (tmp & 0xFF00000000) >> 8;
            var v6 = (tmp & 0xFF0000000000) >> 24;
            var v7 = (tmp & 0xFF000000000000) >> 40;
            var v8 = (tmp & 0xFF00000000000000) >> 56;
            var v = v1 | v2 | v3 | v4 | v5 | v6 | v7 | v8;
            return (long) v;
        }

        public static ushort Convert(ushort val)
        {
            var tmp = val;
            var v1 = (tmp & 0xFF) << 8;
            var v2 = (tmp & 0xFF00) >> 8;
            var v = v1 | v2;
            return (ushort) v;
        }

        public static uint Convert(uint val)
        {
            var tmp = val;
            var v1 = (tmp & 0xFF) << 24;
            var v2 = (tmp & 0xFF00) << 8;
            var v3 = (tmp & 0xFF0000) >> 8;
            var v4 = (tmp & 0xFF000000) >> 24;
            var v = v1 | v2 | v3 | v4;
            return v;
        }

        public static ulong Convert(ulong val)
        {
            var tmp = val;
            var v1 = (tmp & 0xFF) << 56;
            var v2 = (tmp & 0xFF00) << 40;
            var v3 = (tmp & 0xFF0000) << 24;
            var v4 = (tmp & 0xFF000000) << 8;
            var v5 = (tmp & 0xFF00000000) >> 8;
            var v6 = (tmp & 0xFF0000000000) >> 24;
            var v7 = (tmp & 0xFF000000000000) >> 40;
            var v8 = (tmp & 0xFF00000000000000) >> 56;
            var v = v1 | v2 | v3 | v4 | v5 | v6 | v7 | v8;
            return v;
        }
    }
}