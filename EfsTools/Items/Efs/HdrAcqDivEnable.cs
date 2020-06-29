using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_enable", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class HdrAcqDivEnable
    {
        public byte Value { get; set; }
    }
}