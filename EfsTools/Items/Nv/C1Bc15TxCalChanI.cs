using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4321)]
    [Attributes(9)]
    public sealed class C1Bc15TxCalChan
    {
        public ushort[] Value { get; set; }
    }
}