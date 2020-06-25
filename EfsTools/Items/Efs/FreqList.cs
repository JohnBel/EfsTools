using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Subscription]
    [EfsFile("/policyman/freq_list", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class FreqList

    {
        public byte Value { get; set; }
    }
}