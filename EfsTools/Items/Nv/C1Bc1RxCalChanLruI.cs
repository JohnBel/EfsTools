using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2794)]
    [Attributes(9)]
    public sealed class C1Bc1RxCalChanLru
    {
        public byte[] Value { get; set; }
    }
}