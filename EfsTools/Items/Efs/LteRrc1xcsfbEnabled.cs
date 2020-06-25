using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/lte/rrc/lte_rrc_1xcsfb_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteRrc1xcsfbEnabled
    {
        public byte Value { get; set; }
    }
}