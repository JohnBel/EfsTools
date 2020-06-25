using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [EfsFile("/nv/item_files/cdma/1xcp/1xadvanced_capability", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class OneXAdvancedCapability
    {
        public byte Value { get; set; }
    }
}