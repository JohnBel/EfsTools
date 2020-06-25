using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/data/dynamic_port_cfg", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class DynamicPortCfg
    {
        public byte Value { get; set; }
    }
}