using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024847", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33NonbypassBypassTimer
    {
        [FieldCount(2)]
        public ushort[] NonbypassBypassTimerType { get; set; }
    }
}