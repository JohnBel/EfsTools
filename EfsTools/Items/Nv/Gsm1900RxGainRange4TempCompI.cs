using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4388)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange4TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}