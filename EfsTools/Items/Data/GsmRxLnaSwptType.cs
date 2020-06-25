using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class GsmRxLnaSwptType
    {
        public sbyte MaxGainrange1 { get; set; }


        public sbyte MinGainrange2 { get; set; }


        public sbyte MaxGainrange2 { get; set; }


        public sbyte MinGainrange3 { get; set; }


        public sbyte MaxGainrange3 { get; set; }


        public sbyte MinGainrange4 { get; set; }


        public sbyte MaxGainrange4 { get; set; }


        public sbyte MinGainrange5 { get; set; }
    }
}