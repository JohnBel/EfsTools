using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_thresh0", true, 0xE1FF)]
    [Attributes(9)]
    public class HdrAcqDivThresh0
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
    }
}