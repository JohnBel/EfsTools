using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025387", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39IntraCaRxGainVsFreq
    {
        [FieldCount(384)]
        public sbyte[] Value { get; set; }
    }
}