using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5285)]
    [Attributes(9)]
    public sealed class Gsm850PadacDcOffset
    {
        [FieldCount(15)]
        public sbyte[] Value { get; set; }
    }
}