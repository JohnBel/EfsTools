using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3147)]
    [Attributes(9)]
    public sealed class DcsAutocalPwrDacF3
    {
        public short Value1 { get; set; }


        public ushort Value2 { get; set; }
    }
}