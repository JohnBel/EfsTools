using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7045)]
    [Attributes(9)]
    public sealed class Wcdma1500RxfIciQCoef1415
    {
        public uint Value { get; set; }
    }
}