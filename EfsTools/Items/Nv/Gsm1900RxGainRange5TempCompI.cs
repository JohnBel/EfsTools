using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4392)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange5TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}