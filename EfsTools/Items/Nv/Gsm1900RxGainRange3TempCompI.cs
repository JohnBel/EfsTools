using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4384)]
    [Attributes(9)]
    public sealed class Gsm1900RxGainRange3TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}