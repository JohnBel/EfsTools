using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5997)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4RxfIciICoef23
    {
        public uint Value { get; set; }
    }
}