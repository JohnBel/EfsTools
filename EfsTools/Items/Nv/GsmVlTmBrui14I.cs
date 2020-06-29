using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2211)]
    [Attributes(9)]
    public sealed class GsmVlTmBrui14
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}