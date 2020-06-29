using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2749)]
    [Attributes(9)]
    public sealed class Gsm1900AmamDynamicRange
    {
        [FieldCount(2)]
        public int[] Value { get; set; }
    }
}