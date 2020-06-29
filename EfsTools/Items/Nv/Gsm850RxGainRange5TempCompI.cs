using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4389)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange5TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}