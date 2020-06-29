using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(911)]
    [Attributes(9)]
    public sealed class GprsMultiSlotClass
    {
        public byte Value { get; set; }
    }
}