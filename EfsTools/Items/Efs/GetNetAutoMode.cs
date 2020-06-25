using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/mmode/get_net_auto_mode", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GetNetAutoMode
    {
        [Required]
        public byte Version { get; set; }


        public ushort Value { get; set; }


        public ushort Reserved { get; set; }
    }
}