using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_thresh1", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class HdrAcqDivThresh1
    {
        public ushort Value { get; set; }
    }
}