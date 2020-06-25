using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/mmode/c2k_switch_2_srlte", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class C2kSwitch2Srlte
    {
        public byte Value { get; set; }
    }
}