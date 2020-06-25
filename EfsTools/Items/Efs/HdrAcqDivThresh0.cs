using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/hdr/srch/hdr_acq_div_thresh0", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class HdrAcqDivThresh0
    {
        public ushort Value { get; set; }
    }
}