using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/modem/data/3gpp/ps/allow_infinite_throt", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class AllowInfiniteThrot
    {
        public byte Value { get; set; }
    }
}