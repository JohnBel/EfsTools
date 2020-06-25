using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6426)]
    [Attributes(9)]
    public sealed class C1Wcdma1800RxfIciQCoef1415
    {
        public uint Value { get; set; }
    }
}