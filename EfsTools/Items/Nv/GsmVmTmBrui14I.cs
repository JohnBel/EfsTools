using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2229)]
    [Attributes(9)]
    public sealed class GsmVmTmBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}