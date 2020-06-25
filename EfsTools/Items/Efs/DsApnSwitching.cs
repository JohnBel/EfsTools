using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/data/dsd/ds_apn_switching", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DsApnSwitching
    {
        public byte Value { get; set; }
    }
}