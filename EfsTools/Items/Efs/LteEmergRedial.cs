using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(73655)]
    [EfsFile("/nv/item_files/modem/mmode/lte_emerg_redial", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteEmergRedial
    {
        [Required]
        public byte Version { get; set; }


        public uint RedialOnLte { get; set; }
    }
}