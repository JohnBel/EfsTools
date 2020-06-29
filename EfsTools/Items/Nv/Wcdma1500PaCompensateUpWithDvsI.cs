using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6993)]
    [Attributes(9)]
    public sealed class Wcdma1500PaCompensateUpWithDvs
    {
        [FieldCount(10)]
        public short[] Value { get; set; }
    }
}