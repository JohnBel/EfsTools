using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxPwrImbalanceDbm10CoordinateType
    {
        public short XAxisVal { get; set; }


        public short YAxisVal { get; set; }
    }
}