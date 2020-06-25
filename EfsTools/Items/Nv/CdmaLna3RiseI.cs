using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(592)]
    [Attributes(9)]
    public sealed class CdmaLna3Rise
    {
        public sbyte Value { get; set; }
    }
}