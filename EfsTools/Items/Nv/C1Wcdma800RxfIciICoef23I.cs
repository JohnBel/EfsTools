using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6031)]
    [Attributes(9)]
    public sealed class C1Wcdma800RxfIciICoef23
    {
        public uint Value { get; set; }
    }
}