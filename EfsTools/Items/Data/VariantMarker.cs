using System;
using System.Runtime.InteropServices;

namespace EfsTools.Items.Data
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public sealed class VariantMarker
    {
        public ushort Version { get; set; }


        public ushort NumOfElement { get; set; }
    }
}