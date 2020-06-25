using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class QmslTxCalMultiLinearizerIndexNodeRev2NvType
    {
        public ushort UpperBoundChan { get; set; }


        public byte TableOffset { get; set; }


        public byte DpdTableOffset { get; set; }
    }
}