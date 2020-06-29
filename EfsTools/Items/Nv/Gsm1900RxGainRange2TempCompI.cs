using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4380)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange2TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}