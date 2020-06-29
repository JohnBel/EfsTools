using System;

namespace EfsTools.Items.Data
{
    [Serializable]
        public sealed class QmslTxCalMultiLinearizerIndexNodeRev2NvType
    {
        public ushort UpperBoundChan { get; set; }


        public byte TableOffset { get; set; }


        public byte DpdTableOffset { get; set; }
    }
}