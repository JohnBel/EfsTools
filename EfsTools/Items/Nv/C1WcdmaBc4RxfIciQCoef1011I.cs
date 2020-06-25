using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6009)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4RxfIciQCoef1011
    {
        public uint Value { get; set; }
    }
}