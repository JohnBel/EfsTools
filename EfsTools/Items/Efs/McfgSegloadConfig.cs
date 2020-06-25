using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/mcfg/mcfg_segload_config", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class McfgSegloadConfig
    {
        [Required]
        public uint Version { get; set; }


        public uint Value { get; set; }
    }
}