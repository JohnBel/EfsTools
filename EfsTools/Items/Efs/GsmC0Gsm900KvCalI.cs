using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025013", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm900KvCal
    {
        public uint KvCalValue { get; set; }


        public ushort KvCalLowChan { get; set; }


        public ushort KvCalHighChan { get; set; }
    }
}