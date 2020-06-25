using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/qmss_enabled", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class QmssEnabled
    {
        public byte Value { get; set; }
    }
}