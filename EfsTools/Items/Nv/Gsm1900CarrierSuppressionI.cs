using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4872)]
    [Attributes(9)]
    public sealed class Gsm1900CarrierSuppression
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}