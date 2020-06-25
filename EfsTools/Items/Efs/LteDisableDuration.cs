using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/lte_disable_duration", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteDisableDuration
    {
        public uint Value { get; set; }
    }
}