using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5286)]
    [Attributes(9)]
    public sealed class Gsm900PadacDcOffset
    {
        [FieldCount(15)]
        public sbyte[] Value { get; set; }
    }
}